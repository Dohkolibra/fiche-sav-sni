using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FicheSAV
{
    public partial class NouvelleMarque : Form
    {
        //BaseDeDonnee bdd = new BaseDeDonnee();
        MySqlCommand mysqlCmd2;
        MySqlDataReader mysqlReader;
        string marque = "";

        public NouvelleMarque()
        {
            InitializeComponent();
            oui.Visible = false;
            non.Visible = false;
            reponseVerif.Visible = false;
            question.Visible = false;

        }


        private void verifier_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            BaseDeDonnee.Connection();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM marque", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();
            while (mysqlReader.Read() && !existe)
            {
                marque = mysqlReader.GetString("nom_marque");
                if (Marque.Text.ToLower() == marque.ToLower())
                {
                    existe = true;
                    reponseVerif.Text = "Cette marque existe déjà";
                    reponseVerif.ForeColor = Color.Red;
                    reponseVerif.Visible = true;
                    break;
                }
            }
            if (!existe && Marque.Text != "")
            {
                reponseVerif.Text = "Cette marque n'existe pas.\nVoulez vous l'ajouter ?";
                reponseVerif.ForeColor = Color.Green;
                reponseVerif.Visible = true;
                oui.Visible = true;
                non.Visible = true;
                question.Visible = true;
                marque = Marque.Text;
            }
            mysqlReader.Close();
        }

        private void oui_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            mysqlCmd2 = new MySqlCommand("INSERT INTO marque VALUES('','" + marque.Replace("'", "''") + "')", BaseDeDonnee.mysql);
            mysqlCmd2.ExecuteReader();
            mysqlReader.Close();
            this.Close();
        }

        private void non_Click(object sender, EventArgs e)
        {
            this.Close();
        }





   





    }
}
