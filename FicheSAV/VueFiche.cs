using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace FicheSAV
{
    public partial class VueFiche : Form
    {
        public Boolean ficheSelect = false;
        private string idClient = "0";
        int attente = 0;
        int etat = 1;
        Fiche fiche = null;
        DataGridView d = null;
        DataGridViewRow numRow;
        MySqlDataAdapter OSDataAdapter;
        DataSet OSDataSet;
        
        public VueFiche()
        {
            InitializeComponent();
            comboBox2.Hide();
            
            BaseDeDonnee.Connection();
            OSDataAdapter = new MySqlDataAdapter("select * from os", BaseDeDonnee.mysql);
            OSDataSet = new DataSet("os");
            OSDataAdapter.Fill(OSDataSet, "os");
            comboBox2.DataSource = OSDataSet.Tables["os"];
            comboBox2.ValueMember = "nom_os";
            comboBox2.DisplayMember = "nom_os";
            BaseDeDonnee.Deconnection();

        }

        public void setData(Fiche f, ref DataGridView dgv, DataGridViewRow nR)
        {
            d = dgv;
            numRow = nR;
            ResetField();
            fiche = f;
            num_fiche.Text = f.numFiche;
            date_depot.Text = f.dateDepot;
            pass.Text = f.pass;
            nom.Text = f.client.nomClient;
            tel.Text = f.client.tel1Client;
            tel2.Text = f.client.tel2Client;
            adresse.Text = f.client.adresseClient;
            string type = f.materiel.type;
            if (type == "N/C")
            {
                type = "";
            }
            materiel.Text = type + " " + f.materiel.marque + " " + f.materiel.modele;
            accessoire.Text = f.accessoire;
            descriptif.Text = f.panneMateriel;
            idClient = f.client.idClient;
            travauxE.Text = f.travaux;
            villec.Text = f.client.villeClient;
            codepostal.Text = f.client.cpClient;
            comboBox1.SelectedIndex = Int16.Parse(f.typeEnlevement);
            dateTimePicker1.Value = DateTime.Parse(f.reprise);

            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("SELECT nom_os FROM os WHERE id_os=" + fiche.materiel.os, BaseDeDonnee.mysql);
            MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            tbOS.Text = mysqlReader.GetString("nom_os");
            mysqlReader.Close();
            BaseDeDonnee.Deconnection();



            switch (f.etatFiche)
            {
                case "1":
                    ResetProgressBar();
                    label8.BackColor = Color.Aquamarine;
                    break;
                case "2":
                    ResetProgressBar();
                    label8.BackColor = Color.Yellow;
                    label7.BackColor = Color.Yellow;
                    label7.Text = "attente pièces";
                    break;
                case "3":
                    ResetProgressBar();
                    label8.BackColor = Color.Yellow;
                    label7.BackColor = Color.Yellow;
                    label7.Text = "attente assurance";
                    break;
                case "4":
                    ResetProgressBar();
                    label8.BackColor = Color.Yellow;
                    label7.BackColor = Color.Yellow;
                    label7.Text = "attente client";
                    break;
                case "5":
                    ResetProgressBar();
                    label8.BackColor = Color.LawnGreen;
                    label7.BackColor = Color.LawnGreen;
                    label9.BackColor = Color.LawnGreen;
                    break;
                case "6":
                    ResetProgressBar();
                    label8.BackColor = Color.Coral;
                    label7.BackColor = Color.Coral;
                    label9.BackColor = Color.Coral;
                    label10.BackColor = Color.Coral;
                    break;
            }

            date_depot.Select();
        }

        private void VueFiche_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ResetField()
        {
            nom.ReadOnly = true;
            nom.BackColor = Color.FromKnownColor(KnownColor.Menu);
            nom.BorderStyle = BorderStyle.None;
            tel.ReadOnly = true;
            tel.BackColor = Color.FromKnownColor(KnownColor.Menu);
            tel.BorderStyle = BorderStyle.None;
            tel2.ReadOnly = true;
            tel2.BackColor = Color.FromKnownColor(KnownColor.Menu);
            tel2.BorderStyle = BorderStyle.None;
            adresse.ReadOnly = true;
            adresse.BackColor = Color.FromKnownColor(KnownColor.Menu);
            adresse.BorderStyle = BorderStyle.None;
            codepostal.ReadOnly = true;
            codepostal.BackColor = Color.FromKnownColor(KnownColor.Menu);
            codepostal.BorderStyle = BorderStyle.None;
            villec.ReadOnly = true;
            villec.BackColor = Color.FromKnownColor(KnownColor.Menu);
            villec.BorderStyle = BorderStyle.None;
            descriptif.ReadOnly = true;
            descriptif.BackColor = Color.FromKnownColor(KnownColor.Menu);
            descriptif.BorderStyle = BorderStyle.None;
            accessoire.ReadOnly = true;
            accessoire.BackColor = Color.FromKnownColor(KnownColor.Menu);
            accessoire.BorderStyle = BorderStyle.None;
            pass.ReadOnly = true;
            pass.BackColor = Color.FromKnownColor(KnownColor.Menu);
            pass.BorderStyle = BorderStyle.None;
            tbOS.ReadOnly = true;
            tbOS.BackColor = Color.FromKnownColor(KnownColor.Menu);
            tbOS .BorderStyle = BorderStyle.None;
            comboBox2.Hide();
        }

        #region EVENEMENTS MODIFICATION DONNEES

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.Show();
            tbOS.Hide();
        }

        private void tbOS_MouseLeave(object sender, EventArgs e)
        {
            if (tbOS.ReadOnly != false)
                tbOS.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void tbOS_MouseHover(object sender, EventArgs e)
        {
            if (tbOS.ReadOnly != false)
                tbOS.BackColor = Color.LightSkyBlue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbOS.Text != "")
            {
                comboBox2.Hide();
                tbOS.Text = comboBox2.SelectedValue.ToString();
                tbOS.Show();

                BaseDeDonnee.Connection();

                String maRequete = "SELECT * FROM os WHERE nom_os= @nom";
                MySqlCommand mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
                mysqlCmd2.Parameters["@nom"].Value = comboBox2.SelectedValue.ToString();
                MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                String idos = mysqlReader.GetString("id_os");
                mysqlReader.Close();

                maRequete = "UPDATE fiche SET os = @idos WHERE idfiche = @idfi";
                mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@idos", MySqlDbType.String));
                mysqlCmd2.Parameters["@idos"].Value = idos;
                mysqlCmd2.Parameters.Add(new MySqlParameter("@idfi", MySqlDbType.String));
                mysqlCmd2.Parameters["@idfi"].Value = num_fiche.Text;
                mysqlCmd2.ExecuteReader();

                BaseDeDonnee.Deconnection();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET enlevement = '" + dateTimePicker1.Value.ToShortDateString().ToString() + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
            BaseDeDonnee.Deconnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET type_enlevement = '" + comboBox1.SelectedIndex + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
            dateTimePicker1.Value = DateTime.Today;
            BaseDeDonnee.Deconnection();

            BaseDeDonnee.Connection();
            mysqlCmd2 = new MySqlCommand("UPDATE fiche SET enlevement = '" + dateTimePicker1.Value.ToShortDateString().ToString() + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
            BaseDeDonnee.Deconnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Voulez vous supprimer cette fiche ?", "Suppression d'une fiche", MessageBoxButtons.YesNo))
            {
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2;
                MySqlDataReader mysqlReader;
                mysqlCmd2 = new MySqlCommand("DELETE FROM fiche WHERE idfiche = " + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();

                mysqlReader.Read();
                mysqlReader.Close();
                d.Rows.Remove(numRow);
                d.Refresh();
            }

        }

        private void nom_MouseHover(object sender, EventArgs e)
        {
            if (nom.ReadOnly != false)
                nom.BackColor = Color.LightSkyBlue;
        }

        private void nom_MouseLeave(object sender, EventArgs e)
        {
            if (nom.ReadOnly != false)
                nom.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void nom_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            nom.ReadOnly = false;
            nom.BackColor = Color.White;
            nom.BorderStyle = BorderStyle.FixedSingle;
            
        }

        private void nom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                nom.ReadOnly = true;
                nom.BackColor = Color.FromKnownColor(KnownColor.Menu);
                nom.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du nom
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET nom = '" + nom.Text + "' WHERE idclient =" + idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }
    

        private void tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                tel.ReadOnly = true;
                tel.BackColor = Color.FromKnownColor(KnownColor.Menu);
                tel.BorderStyle = BorderStyle.None;
                date_depot.Focus();
               
                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET tel1 = '"+tel.Text+"' WHERE idclient ="+idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }

        private void tel_MouseHover(object sender, EventArgs e)
        {
            if (tel.ReadOnly != false)
                tel.BackColor = Color.LightSkyBlue;
        }

        private void tel_MouseLeave(object sender, EventArgs e)
        {
            if (tel.ReadOnly != false)
                tel.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void tel_MouseClick(object sender, MouseEventArgs e)
        {
            {
                ResetField();
                tel.ReadOnly = false;
                tel.BackColor = Color.White;
                tel.BorderStyle = BorderStyle.FixedSingle;
            }
        }


        private void travauxE_KeyDown(object sender, KeyEventArgs e)
        {
            MySqlCommand mysqlCmd2;
            MySqlDataReader mysqlReader;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                BaseDeDonnee.Connection();

                string requete = "UPDATE fiche SET travaux = @travaux WHERE idfiche = @num_fiche";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@travaux", MySqlDbType.String));
                mysqlCmd2.Parameters["@travaux"].Value = travauxE.Text;
                mysqlCmd2.Parameters.Add(new MySqlParameter("@num_fiche", MySqlDbType.String));
                mysqlCmd2.Parameters["@num_fiche"].Value = num_fiche.Text;
                mysqlReader = mysqlCmd2.ExecuteReader();

                BaseDeDonnee.Deconnection();
            }
        }


        private void tel2_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            tel2.ReadOnly = false;
            tel2.BackColor = Color.White;
            tel2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tel2_MouseLeave(object sender, EventArgs e)
        {
            if (tel2.ReadOnly != false)
                tel2.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void tel2_MouseHover(object sender, EventArgs e)
        {
            if (tel2.ReadOnly != false)
                tel2.BackColor = Color.LightSkyBlue;
        }

        private void tel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                tel2.ReadOnly = true;
                tel2.BackColor = Color.FromKnownColor(KnownColor.Menu);
                tel2.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET tel2 = '" + tel2.Text + "' WHERE idclient =" + idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }

        }


        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (adresse.ReadOnly != false)
                adresse.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (adresse.ReadOnly != false)
                adresse.BackColor = Color.LightSkyBlue;
        }

        private void adresse_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            adresse.ReadOnly = false;
            adresse.BackColor = Color.White;
            adresse.BorderStyle = BorderStyle.FixedSingle;
        }

        private void adresse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                adresse.ReadOnly = true;
                adresse.BackColor = Color.FromKnownColor(KnownColor.Menu);
                adresse.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET adresse = '" + adresse.Text + "' WHERE idclient =" + idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }


        private void codepostal_MouseHover(object sender, EventArgs e)
        {
            if (codepostal.ReadOnly != false)
                codepostal.BackColor = Color.LightSkyBlue;
        }

        private void codepostal_MouseLeave(object sender, EventArgs e)
        {
            if (codepostal.ReadOnly != false)
                codepostal.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void codepostal_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            codepostal.ReadOnly = false;
            codepostal.BackColor = Color.White;
            codepostal.BorderStyle = BorderStyle.FixedSingle;
        }

        private void codepostal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                codepostal.ReadOnly = true;
                codepostal.BackColor = Color.FromKnownColor(KnownColor.Menu);
                codepostal.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET cp = '" + codepostal.Text + "' WHERE idclient =" + idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }


        private void villec_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            villec.ReadOnly = false;
            villec.BackColor = Color.White;
            villec.BorderStyle = BorderStyle.FixedSingle;
        }

        private void villec_MouseHover(object sender, EventArgs e)
        {
            if (villec.ReadOnly != false)
                villec.BackColor = Color.LightSkyBlue;
        }

        private void villec_MouseLeave(object sender, EventArgs e)
        {
            if (villec.ReadOnly != false)
                villec.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void villec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                villec.ReadOnly = true;
                villec.BackColor = Color.FromKnownColor(KnownColor.Menu);
                villec.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE client SET ville = '" + villec.Text + "' WHERE idclient =" + idClient, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }


        private void descriptif_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            descriptif.ReadOnly = false;
            descriptif.BackColor = Color.White;
            descriptif.BorderStyle = BorderStyle.FixedSingle;
        }

        private void descriptif_MouseHover(object sender, EventArgs e)
        {
            if (descriptif.ReadOnly != false)
                descriptif.BackColor = Color.LightSkyBlue;
        }

        private void descriptif_MouseLeave(object sender, EventArgs e)
        {
            if (descriptif.ReadOnly != false)
                descriptif.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void descriptif_KeyDown(object sender, KeyEventArgs e)
        {
            MySqlCommand mysqlCmd2;
            MySqlDataReader mysqlReader;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                descriptif.ReadOnly = true;
                descriptif.BackColor = Color.FromKnownColor(KnownColor.Menu);
                descriptif.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                BaseDeDonnee.Connection();
                string requete = "UPDATE fiche SET descriptif = @panne WHERE idfiche = @num_fiche";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@panne", MySqlDbType.String));
                mysqlCmd2.Parameters["@panne"].Value = descriptif.Text;
                mysqlCmd2.Parameters.Add(new MySqlParameter("@num_fiche", MySqlDbType.String));
                mysqlCmd2.Parameters["@num_fiche"].Value = num_fiche.Text;
                mysqlReader = mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }


        private void accessoire_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            accessoire.ReadOnly = false;
            accessoire.BackColor = Color.White;
            accessoire.BorderStyle = BorderStyle.FixedSingle;
        }

        private void accessoire_MouseHover(object sender, EventArgs e)
        {
            if (accessoire.ReadOnly != false)
                accessoire.BackColor = Color.LightSkyBlue;
        }

        private void accessoire_MouseLeave(object sender, EventArgs e)
        {
            if (accessoire.ReadOnly != false)
                accessoire.BackColor = Color.FromKnownColor(KnownColor.Menu);
        }

        private void accessoire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                accessoire.ReadOnly = true;
                accessoire.BackColor = Color.FromKnownColor(KnownColor.Menu);
                accessoire.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET accessoires = '" + accessoire.Text + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        }


        private void pass_MouseHover(object sender, EventArgs e)
        {
            if (pass.ReadOnly != false)
                pass.BackColor = Color.LightSkyBlue;
        }

        private void pass_MouseLeave(object sender, EventArgs e)
        {
            if (pass.ReadOnly != false)
                pass.BackColor = Color.LightSkyBlue;
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            ResetField();
            pass.ReadOnly = false;
            pass.BackColor = Color.White;
            pass.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                pass.ReadOnly = true;
                pass.BackColor = Color.FromKnownColor(KnownColor.Menu);
                pass.BorderStyle = BorderStyle.None;
                date_depot.Focus();

                //requete de mise a jour du tel
                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET pass = '" + pass.Text + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
                BaseDeDonnee.Deconnection();
            }
        } 

        #endregion

        #region PROGRESSBAR

        private void label7_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
            label8.BackColor = Color.Yellow;
            label7.BackColor = Color.Yellow;
            attente = (attente + 1) % 3;

            if (attente == 0)
            {
                label7.Text = "attente pièces";
                etat = 2;

                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
            }
            else if (attente == 1)
            {
                label7.Text = "attente assurance";
                etat = 3;

                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
            }
            else if (attente == 2)
            {
                label7.Text = "attente client";
                etat = 4;

                BaseDeDonnee.Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteReader();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
            attente = 0;
            label8.BackColor = Color.Aquamarine;
            etat = 1;


            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
            attente = 0;
            label8.BackColor = Color.LawnGreen;
            label7.BackColor = Color.LawnGreen;
            label9.BackColor = Color.LawnGreen;
            etat = 5;


            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
            attente = 0;
            label8.BackColor = Color.Coral;
            label7.BackColor = Color.Coral;
            label9.BackColor = Color.Coral;
            label10.BackColor = Color.Coral;
            etat = 6;

            BaseDeDonnee.Connection();
            MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE fiche SET etat = '" + etat + "' WHERE idfiche =" + num_fiche.Text, BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
        }

        private void ResetProgressBar()
        {
            label8.BackColor = Color.FromKnownColor(KnownColor.Control);
            label7.BackColor = Color.FromKnownColor(KnownColor.Control);
            label9.BackColor = Color.FromKnownColor(KnownColor.Control);
            label10.BackColor = Color.FromKnownColor(KnownColor.Control);
            label7.Text = "attente";
        }

        #endregion

        #region IMPRESSION

        private void printButton_Click(object sender, EventArgs e)
        {
            Impression imp = new Impression(fiche);
            imp.Imprimer();
        }




        #endregion








    }
}
