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
    public partial class NouveauType : Form
    {
        BaseDeDonnee bdd = new BaseDeDonnee();
        MySqlCommand mysqlCmd2;
        MySqlDataReader mysqlReader;
        string os = "";

        public NouveauType()
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
            bdd.Connection();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM materiel", bdd.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read() && !existe)
            {
                os = mysqlReader.GetString("nom_materiel");
                if (Materiel.Text.ToLower() == os.ToLower())
                {
                    existe = true;
                    reponseVerif.Text = "Ce matériel existe déjà";
                    reponseVerif.ForeColor = Color.Red;
                    reponseVerif.Visible = true;
                    break;
                }
            }
            if (!existe && Materiel.Text != "")
            {
                reponseVerif.Text = "Ce matériel n'existe pas ?";
                reponseVerif.ForeColor = Color.Green;
                reponseVerif.Visible = true;
                oui.Visible = true;
                non.Visible = true;
                question.Visible = true;
                os = Materiel.Text;
            }
            mysqlReader.Close();
        }

        private void oui_Click(object sender, EventArgs e)
        {
            bdd.Connection();

            mysqlCmd2 = new MySqlCommand("INSERT INTO materiel VALUES('','" + os.Replace("'", "''") + "')", bdd.mysql);
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
