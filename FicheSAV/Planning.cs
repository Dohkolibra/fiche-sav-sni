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
    public partial class Planning : Form
    {
        Boolean selection = false;

        public Planning()
        {
            InitializeComponent();
            BaseDeDonnee bdd = new BaseDeDonnee();
            bdd.Connection();

            MySqlCommand mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche WHERE etat = '1' OR etat = '2' OR etat = '3' OR etat = '4' ", bdd.mysql);
            MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();
            int nombre = 0;

            while (mysqlReader.Read())
            {
                BaseDeDonnee bdd2 = new BaseDeDonnee();
                bdd2.Connection();
                MySqlCommand mysqlCmd3 = new MySqlCommand("SELECT nom FROM client WHERE idclient =" + mysqlReader.GetString("idclient") , bdd2.mysql);
                MySqlDataReader mysqlReader2 = mysqlCmd3.ExecuteReader();
                mysqlReader2.Read();
                string nom = mysqlReader2.GetString("nom");
                mysqlReader2.Close();

                mysqlCmd3 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + mysqlReader.GetString("type_materiel"), bdd2.mysql);
                mysqlReader2 = mysqlCmd3.ExecuteReader();
                mysqlReader2.Read();
                string type = mysqlReader2.GetString("nom_materiel");
                mysqlReader2.Close();

                mysqlCmd3 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + mysqlReader.GetString("marque"), bdd2.mysql);
                mysqlReader2 = mysqlCmd3.ExecuteReader();
                mysqlReader2.Read();
                string marque = mysqlReader2.GetString("nom_marque");
                mysqlReader2.Close();


                Panel pan = new Panel();
                pan.Size = new Size(181, 237);
                pan.Location = new Point(nombre * 185, 0);
                pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                pan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_Click);

                Label lidfiche = new Label();
                lidfiche.Text = mysqlReader.GetString("idfiche");
                lidfiche.TextAlign = ContentAlignment.MiddleCenter;
                lidfiche.Size = new Size(185, 15);
                lidfiche.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pan.Controls.Add(lidfiche);

                Label lidclient = new Label();
                lidclient.Text = nom;
                pan.Controls.Add(lidclient);
                lidclient.Location = new Point(0, 30);
                lidclient.Size = new Size(185, 20);
                lidclient.TextAlign = ContentAlignment.MiddleCenter;

                Label lmateriel = new Label();
                lmateriel.Text = type + " " + marque + "\n" + mysqlReader.GetString("designation");
                pan.Controls.Add(lmateriel);
                lmateriel.Location = new Point(0, 50);
                lmateriel.Size = new Size(185, 40);
                lmateriel.TextAlign = ContentAlignment.MiddleCenter;
                  
                nombre++;
                flowLayoutPanel1.Controls.Add(pan);
            }

            mysqlReader.Close();

            bdd.mysql.Close();
        }




        private void panel1_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (((Panel)sender).BackColor != Color.Red)  // si le panel n'es pas vide
            {
                selection = true;
                ((Panel)sender).BackColor = Color.Red;
            }
            else
            {
                selection = false;
                ((Panel)sender).BackColor = Color.WhiteSmoke;
            }
        }







    }
}
