using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZedGraph;

namespace FicheSAV
{
    public partial class Form1 : Form
    { 
        MySqlConnection mysql;
        Boolean new_client;
        MySqlCommand mysqlCmd2;
        MySqlDataReader mysqlReader;
        Random rndNumbers = new Random();

        public Form1()
        {
            InitializeComponent();
            DateDuJour();
            new_client = false; 

            tel1Box.Hide();
            tel2Box.Hide();
            adresseBox.Hide();
            ltel.Hide();
            ladresse.Hide();
            lville.Hide();
            villeBox.Hide();
            lcp.Hide();
            cpBox.Hide();
            lmail.Hide();
            mailBox.Hide();
            listClient.Hide();

            Connection();
            RemplirOS();
            RemplirPriorite();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /* Affiche la date du jour dans la création de fiche SAV */
        private void DateDuJour()
        {
            dateBox.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        /* pour remplir la liste des OS disponible */
        private void RemplirOS()
        {
            mysqlCmd2 = new MySqlCommand("SELECT * FROM os ", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();
            while (mysqlReader.Read())
            {
                String os = mysqlReader.GetString("nom_os");
                OSlist.Items.Add(os);
            }  
            mysqlReader.Close();
            OSlist.SelectedIndex = OSlist.Items.Count - 1;
        }

        private void RemplirPriorite()
        {
            mysqlCmd2 = new MySqlCommand("SELECT * FROM priorite ", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();
            while (mysqlReader.Read())
            {
                String prio = mysqlReader.GetString("nom_prio");
                prioriteBox.Items.Add(prio);
            }
            mysqlReader.Close();
            prioriteBox.SelectedIndex = 0;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            String date =            dateBox.Text;
            String nom_client =      nameBox.Text;
            String tel1 =            tel1Box.Text;       
            String tel2 =            tel2Box.Text;
            String adresse =         adresseBox.Text;
            String pass =            passBox.Text;
            String type =            typeBox.Text;
            String marque =          marqueBox.Text;
            String modele =          modeleBox.Text;
            String accessoire =      accessoiresBox.Text;
            String desc =            descriptifBox.Text;
            String cp =              cpBox.Text;
            String ville =           villeBox.Text;
            String mail =            mailBox.Text;
            int    num_os =          OSlist.SelectedIndex + 1;
            int    num_prio =        prioriteBox.SelectedIndex + 1;

            Connection();

            if(!new_client && nom_client != "")
            {
                //verificiation de l'id client si il existe
                mysqlCmd2 = new MySqlCommand("SELECT * FROM client WHERE nom ='" + nom_client + "' LIMIT 1", mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                int idClient = mysqlReader.GetInt32("idclient");
                mysqlReader.Close();

                mysqlCmd2 = new MySqlCommand("INSERT INTO fiche VALUES('','" + date + "','" + pass + "','" + type + "','" + modele + "','" + marque + "','" + accessoire + "','" + desc.Replace("'", "''") + "','" + idClient + "','/','/','/','/','/','" + 0 + "','" + num_prio + "','" + num_os + "')", mysql);
                mysqlCmd2.ExecuteReader();
            }
            else//sinon creer le client
            {
                mysqlCmd2 = new MySqlCommand("INSERT INTO client VALUES('','"+nom_client.Replace("'","''")+"','"+adresse.Replace("'","''")+"','"+cp+"','"+ville.Replace("'","''")+"','"+tel1+"','"+tel2+"','"+mail+"')", mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Close();

                mysqlCmd2 = new MySqlCommand("SELECT idclient FROM client WHERE nom = '"+nom_client+"'",mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                int idClient = mysqlReader.GetInt32("idclient");
                mysqlReader.Close();

                mysqlCmd2 = new MySqlCommand("INSERT INTO fiche VALUES('','" + date + "','" + pass + "','" + type + "','" + modele + "','" + marque + "','" + accessoire + "','" + desc.Replace("'", "''") + "','" + idClient + "','/','/','/','/','/','" + 0 + "','" + num_prio + "','" + num_os + "')", mysql);
                mysqlCmd2.ExecuteReader();
                mysqlReader.Close();
            }

            new_client = false;
            ResetCreationFiche();
        }

        private void ResetCreationFiche()
        {
            DateDuJour();
            new_client = false;

            nameBox.Text = "";
            tel1Box.Hide();
            tel1Box.Text = "";
            tel2Box.Hide();
            tel2Box.Text = "";
            adresseBox.Hide();
            adresseBox.Text = "";
            ltel.Hide();
            ladresse.Hide();
            lville.Hide();
            villeBox.Hide();
            villeBox.Text = "";
            lcp.Hide();
            cpBox.Hide();
            cpBox.Text = "";
            lmail.Hide();
            mailBox.Hide();
            mailBox.Text = "";
            listClient.Hide();
            listClient.Items.Clear();
            passBox.Text = "";
            typeBox.Text = "";
            marqueBox.Text = "";
            modeleBox.Text = "";
            accessoiresBox.Text = "";
            descriptifBox.Text = "";
            OSlist.SelectedIndex = OSlist.Items.Count -1;
        }
        
        // pour se connecter a la DB
        private void Connection()
        {
            mysql = new MySqlConnection("datasource=localhost;username=root;password='';database=mafichesav");

            try
            {
                mysql.Open();
                Console.WriteLine("connection effectuée");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connection");
                MessageBox.Show(ex.Message);
            }
        }

        // pour la saisie semi auto des clients.
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (!new_client)
            {
                Connection();
                MySqlCommand mysqlCmd2 = new MySqlCommand("SELECT * FROM client WHERE nom LIKE'" + nameBox.Text + "%' LIMIT 4", mysql);
                MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();

                //on efface la liste sinon les clients s'ajoute à la suite
                listClient.Items.Clear();

                while (mysqlReader.Read())
                {
                    listClient.Items.Add(mysqlReader.GetString("nom"));
                }
                listClient.Show();

                mysqlReader.Close();
            }

        }

        // affiche ou nom les elements lors de la création d'un nouveau client
        private void newClient_Click(object sender, EventArgs e)
        {
            tel1Box.Show();
            tel2Box.Show();
            adresseBox.Show();
            ltel.Show();
            ladresse.Show();
            lville.Show();
            villeBox.Show();
            lcp.Show();
            cpBox.Show();
            lmail.Show();
            mailBox.Show();
            listClient.Hide();
            new_client = true;

        }

        //selection d'un client dans la liste proposée
        private void listClient_DoubleClick(object sender, EventArgs e)
        {
        
                MySqlCommand mysqlCmd2 = new MySqlCommand("SELECT * FROM client WHERE nom LIKE'%" + listClient.GetItemText(listClient.SelectedItem) + "%' LIMIT 4", mysql);
                MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                
               
                tel1Box.Show();
                tel2Box.Show();
                adresseBox.Show();
                ltel.Show();
                ladresse.Show();
                lville.Show();
                villeBox.Show();
                lcp.Show();
                cpBox.Show();
                lmail.Show();
                mailBox.Show();

                nameBox.Text = mysqlReader.GetString("nom");
                tel1Box.Text = mysqlReader.GetString("tel1");
                tel2Box.Text = mysqlReader.GetString("tel2");
                adresseBox.Text = mysqlReader.GetString("adresse");
                villeBox.Text = mysqlReader.GetString("ville");
                cpBox.Text = mysqlReader.GetString("cp");;
                mailBox.Text = mysqlReader.GetString("mail"); ;

                listClient.Hide();
    
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCreationFiche();
            CreateGraphOS(graphOS);
            CreateGraphEtat(graphEtat);
        }

        //pour creer un graph
        private void CreateGraphOS(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the Titles
            myPane.Title.Text = "Statistiques selon l'OS";
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsVisible = false;

            mysqlCmd2 = new MySqlCommand("SELECT * FROM os", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            String[] tabOS;
            int[] tabCount;
            int i = 0;

            int nbOs = 7;

            tabOS = new String[nbOs];
            tabCount = new int[nbOs];

            while(mysqlReader.Read())
            {
                tabOS[i] = mysqlReader.GetString("nom_os");
                i++;
            }
            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabCount[mysqlReader.GetInt32("os")]++;
            }

            mysqlReader.Close();

            for(i = 0; i < nbOs ; i++)
            {
                myPane.AddPieSlice(tabCount[i], Color.FromArgb(rndNumbers.Next(255), rndNumbers.Next(255), rndNumbers.Next(255)), 0, tabOS[i] + " (" + tabCount[i] + ")");
            }
  
        
        }

        private void CreateGraphEtat(ZedGraphControl zgc)
        {
    
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the Titles
            myPane.Title.Text = "Statistiques selon l'état";
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsVisible = false;

            mysqlCmd2 = new MySqlCommand("SELECT * FROM etat", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            String[] tabEtat;
            int[] tabCount;
            int i = 0;

            int nbOs = 4;

            tabEtat = new String[nbOs];
            tabCount = new int[nbOs];

            while (mysqlReader.Read())
            {
                tabEtat[i] = mysqlReader.GetString("nom_etat");
                i++;
            }
            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche", mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabCount[mysqlReader.GetInt32("clot")]++;
            }

            mysqlReader.Close();
            for (i = 0; i < nbOs; i++)
            {
                myPane.AddPieSlice(tabCount[i], Color.FromArgb(rndNumbers.Next(255), rndNumbers.Next(255), rndNumbers.Next(255)), 0, tabEtat[i]+" ("+tabCount[i]+")");
            }

        }



    }
}
