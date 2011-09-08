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
using System.Drawing.Printing;
using System.Xml;
using System.IO;


namespace FicheSAV
{
    public partial class FenetrePrincipale : Form
    {

        #region ----- VARIABLES -----
        Boolean new_client;
        MySqlCommand mysqlCmd2;
        MySqlDataReader mysqlReader;
        Random rndNumbers = new Random();
        VueFiche vf;
        Boolean clientExiste;
        //BaseDeDonnee bdd = new BaseDeDonnee();
        Fiche fiche = null;
        int idClientRecherche;
        string numFiche;
        string date;
        string nomClient;
        string tel1;
        string tel2;
        string adresse;
        string pass;
        int type;
        int marque;
        string modele;
        string accessoire;
        string desc;
        string cp;
        string ville;
        string mail;
        int num_os;
        int num_prio;
        int id;
        //Planning planning;

        MySqlDataAdapter MaterielDataAdapter;
        DataSet materielDataSet;
        MySqlDataAdapter MarqueDataAdapter;
        DataSet MarqueDataSet;
        MySqlDataAdapter OSDataAdapter;
        DataSet OSDataSet;

        #endregion

        public FenetrePrincipale()
        {
            InitializeComponent();
            
            InitIpServeur();
            vf = new VueFiche();
            //BaseDeDonnee.Connection();
            RemplirComboBox();
            ResetCreationFiche();        
            //planning = new Planning();
            //planning.Show();
            dateBox.Focus();
            //BaseDeDonnee.Deconnection();
        }


        #region ----- FONCTIONS UTILES -----

        /* Sert quand on modifie l'ip du serveur */
        private void InitIpServeur()
        {
            if(File.Exists(@"config.xml"))
            {
                XmlDocument preference = new XmlDocument();
                preference.Load(@"config.xml");
                XmlNode ServeurIp = preference.SelectSingleNode("config/serveur");
                BaseDeDonnee.AdIp = ServeurIp.Attributes["ip"].Value;
            }
        }

        /* Affiche la date du jour dans la création de fiche SAV */
        private void DateDuJour()
        {
            dateBox.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        /* Rempli les ComboBox avec les tables SQL */
        private void RemplirComboBox()
        {
            BaseDeDonnee.Connection();

            MaterielDataAdapter = new MySqlDataAdapter("select * from materiel", BaseDeDonnee.mysql);
            materielDataSet = new DataSet("materiel");
            MaterielDataAdapter.Fill(materielDataSet, "materiel");
            //this.comboMatos.DataBindings.Add("SelectedItem", materielDataSet.Tables["materiel"], "Materiel");
            this.comboMatos.DataSource = materielDataSet.Tables["materiel"];
            this.comboMatos.ValueMember = "id_materiel";
            this.comboMatos.DisplayMember = "nom_materiel";

            MarqueDataAdapter = new MySqlDataAdapter("select * from marque", BaseDeDonnee.mysql);
            MarqueDataSet = new DataSet("marque");
            MarqueDataAdapter.Fill(MarqueDataSet, "marque");
            //this.MarqueList.DataBindings.Add("SelectedItem", MarqueDataSet.Tables["marque"], "Marque");
            this.MarqueList.DataSource = MarqueDataSet.Tables["marque"];
            this.MarqueList.ValueMember = "idmarque";
            this.MarqueList.DisplayMember = "nom_marque";

            OSDataAdapter = new MySqlDataAdapter("select * from os", BaseDeDonnee.mysql);
            OSDataSet = new DataSet("os");
            OSDataAdapter.Fill(OSDataSet, "os");
            //this.OSlist.DataBindings.Add("SelectedItem", OSDataSet.Tables["os"], "Os");
            this.OSlist.DataSource = OSDataSet.Tables["os"];
            this.OSlist.ValueMember = "id_os";
            this.OSlist.DisplayMember = "nom_os";

            BaseDeDonnee.Deconnection();
        }

        /* Click sur le boutton Quitter l'application */
        private void quitter_Click(object sender, EventArgs e)
        {
            //mysqlReader.Close();
            BaseDeDonnee.Deconnection();
            Environment.Exit(0);
        }

        /* Lorsque que l'on change de tab, on remet a zéro la fiche et on met a jour les stats */
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCreationFiche();
            CreateGraphOS(graphOS);
            CreateGraphEtat(graphEtat);
            CreateGraphMarque(graphMarque);
        }

        /* Remet les champs à zéro de la fiche */
        private void ResetCreationFiche()
        {
            DateDuJour();
            new_client = false;
            clientExiste = false;
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
            listBox2.Hide();
            passBox.Text = "";
            modeleBox.Text = "";
            accessoiresBox.Text = "";
            descriptifBox.Text = "";
            comboMatos.SelectedIndex = 0;
            MarqueList.SelectedIndex = 0;
            OSlist.SelectedIndex = 0;
            listBox1.Hide();
        }
       
        private void FenetrePrincipale_Resize(object sender, EventArgs e)
        {
            if (System.Windows.Forms.FormWindowState.Minimized == this.WindowState && vf.ficheSelect)
            {
                vf.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                //planning.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            }
            else if (System.Windows.Forms.FormWindowState.Normal == this.WindowState && vf.ficheSelect)
            {
                vf.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //planning.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }


        }

        private void AfficheVueFiche()
        {
            BaseDeDonnee.Connection();
            if (dataGridView1.Rows.Count != 0)
            {
                fiche = new Fiche();

                vf.ficheSelect = true;
                vf.Location = new Point(750, 0);

                /* recuperer les données de la fiche avec tab[1] qui donne le num de la fiche */
                fiche.numFiche = dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;

                //requete pour avoir les données dans la table fiche ***************************
                //mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche WHERE idfiche =" + fiche.numFiche, BaseDeDonnee.mysql);

                string maRequete = "SELECT * FROM fiche WHERE idfiche = @id_fiche";
                mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@id_fiche", MySqlDbType.Int32));
                mysqlCmd2.Parameters["@id_fiche"].Value = Convert.ToInt32(fiche.numFiche); 

                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();

                fiche.dateDepot = mysqlReader.GetString("date_depot");
                fiche.client.idClient = mysqlReader.GetString("idclient");
                fiche.pass = mysqlReader.GetString("pass");
                fiche.materiel.type = mysqlReader.GetString("type_materiel");
                fiche.materiel.modele = mysqlReader.GetString("designation");
                fiche.materiel.marque = mysqlReader.GetString("marque");
                fiche.materiel.os = mysqlReader.GetString("os");
                fiche.accessoire = mysqlReader.GetString("accessoires");
                fiche.panneMateriel = mysqlReader.GetString("descriptif");
                fiche.etatFiche = mysqlReader.GetString("etat");
                fiche.travaux = mysqlReader.GetString("travaux");
                fiche.typeEnlevement = mysqlReader.GetString("type_enlevement");
                fiche.reprise = mysqlReader.GetString("enlevement");
                mysqlReader.Close();
                /******************************************************************************/

                //recuperer les infos sur le client ********************************************
                maRequete = "SELECT * FROM client WHERE idclient = @id_client";
                mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@id_client", MySqlDbType.String));
                mysqlCmd2.Parameters["@id_client"].Value = fiche.client.idClient; 
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();

                fiche.client.nomClient = mysqlReader.GetString("nom");
                fiche.client.adresseClient = mysqlReader.GetString("adresse");
                fiche.client.villeClient = mysqlReader.GetString("ville");
                fiche.client.cpClient = mysqlReader.GetString("cp");
                fiche.client.tel1Client = mysqlReader.GetString("tel1");
                fiche.client.tel2Client = mysqlReader.GetString("tel2");
                mysqlReader.Close();

                //recupere la marque
                //mysqlCmd2 = new MySqlCommand("SELECT * FROM marque WHERE idmarque =" + fiche.materiel.marque, BaseDeDonnee.mysql);

                maRequete = "SELECT * FROM marque WHERE idmarque = @id_marque";
                mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@id_marque", MySqlDbType.String));
                mysqlCmd2.Parameters["@id_marque"].Value = fiche.materiel.marque; 

                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                fiche.materiel.marque = mysqlReader.GetString("nom_marque");
                mysqlReader.Close();

                //recupere le type de matériel
                //mysqlCmd2 = new MySqlCommand("SELECT * FROM materiel WHERE id_materiel =" + fiche.materiel.type, BaseDeDonnee.mysql);

                maRequete = "SELECT * FROM materiel WHERE id_materiel = @id_materiel";
                mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@id_materiel", MySqlDbType.String));
                mysqlCmd2.Parameters["@id_materiel"].Value = fiche.materiel.type; 

                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                fiche.materiel.type = mysqlReader.GetString("nom_materiel");
                mysqlReader.Close();


                vf.setData(fiche, ref dataGridView1, dataGridView1.CurrentRow);
                vf.Show();
                vf.ShowInTaskbar = true;
            }
            BaseDeDonnee.Deconnection();
        }

        #endregion

        #region ----- CREATION FICHE SAV -----

        /* Lorsque l'on valide la fiche SAV */
        private void valider_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            date = dateBox.Text;
            nomClient = nameBox.Text;
            tel1 = tel1Box.Text;
            tel2 = tel2Box.Text;
            adresse = adresseBox.Text;
            pass = passBox.Text;
            type = comboMatos.SelectedIndex + 1;
            marque = MarqueList.SelectedIndex + 1;
            modele = modeleBox.Text;
            accessoire = accessoiresBox.Text;
            desc = descriptifBox.Text;
            cp = cpBox.Text;
            ville = villeBox.Text;
            mail = mailBox.Text;
            num_os = OSlist.SelectedIndex + 1;
            num_prio = 1;

            if (!new_client && nomClient != "")
            {
                //verificiation de l'id client si il existe
                //mysqlCmd2 = new MySqlCommand("SELECT * FROM client WHERE nom ='" + nomClient.Replace("'", "''") + "' LIMIT 1", BaseDeDonnee.mysql);

                string requete = "SELECT * FROM client WHERE nom = @nom_client LIMIT 1";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@nom_client", MySqlDbType.String));
                mysqlCmd2.Parameters["@nom_client"].Value = nomClient.Replace("'", "''");

                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                id = mysqlReader.GetInt32("idclient");
                mysqlReader.Close();

                //mysqlCmd2 = new MySqlCommand("INSERT INTO fiche VALUES('','" + date + "','" + pass + "','" + type + "','" + modele + "','" + marque + "','" + accessoire + "','" + desc.Replace("'", "''") + "','" + id + "','/','/','"+ date +"','/','/','" + 1 + "','" + num_prio + "','" + num_os + "','" + "','" + "-1')", BaseDeDonnee.mysql);
                
            }
            else//sinon creer le client
            {
                mysqlCmd2 = new MySqlCommand("INSERT INTO client VALUES('','" + nomClient.Replace("'", "''") + "','" + adresse.Replace("'", "''") + "','" + cp + "','" + ville.Replace("'", "''") + "','" + tel1 + "','" + tel2 + "','" + mail + "')", BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Close();

                mysqlCmd2 = new MySqlCommand("SELECT idclient FROM client WHERE nom = '" + nomClient + "'", BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();
                id = mysqlReader.GetInt32("idclient");
                mysqlReader.Close();

           /*     mysqlCmd2 = new MySqlCommand("INSERT INTO fiche VALUES('','" + date + "','" + pass + "','" + type + "','" + modele + "','" + marque + "','" + accessoire + "','" + desc.Replace("'", "''") + "','" + id + "','/','/','" + date + "','/','/','" + 1 + "','" + num_prio + "','" + num_os + "','" + "','" + "-1')", BaseDeDonnee.mysql);
                mysqlCmd2.ExecuteNonQuery();*/
                
            }

            string maRequete = "INSERT INTO fiche VALUES(@idfiche, @date, @pass, @type, @modele, @marque, @accessoire, @desc, @id, '@appel', '@pret', @date, '@facture', '@accord', 1, @num_prio, @num_os, @travaux ,-1)";
            mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
            mysqlCmd2.Parameters.Add(new MySqlParameter("@idfiche", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@date", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@type", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@modele", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@marque", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@accessoire", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@desc", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@appel", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@pret", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@facture", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@accord", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@etat", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@num_prio", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@num_os", MySqlDbType.Int32));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@travaux", MySqlDbType.String));
            mysqlCmd2.Parameters.Add(new MySqlParameter("@enlevement", MySqlDbType.String));
            mysqlCmd2.Parameters["@idfiche"].Value = "";
            mysqlCmd2.Parameters["@date"].Value = date;
            mysqlCmd2.Parameters["@pass"].Value = pass;
            mysqlCmd2.Parameters["@type"].Value = type;
            mysqlCmd2.Parameters["@modele"].Value = modele;
            mysqlCmd2.Parameters["@marque"].Value = marque;
            mysqlCmd2.Parameters["@accessoire"].Value = accessoire;
            mysqlCmd2.Parameters["@desc"].Value = desc.Replace("'", "''");
            mysqlCmd2.Parameters["@id"].Value = id;
            mysqlCmd2.Parameters["@appel"].Value = "";
            mysqlCmd2.Parameters["@pret"].Value = "";
            mysqlCmd2.Parameters["@facture"].Value = date;
            mysqlCmd2.Parameters["@accord"].Value = "";
            mysqlCmd2.Parameters["@etat"].Value = 1;
            mysqlCmd2.Parameters["@num_prio"].Value = num_prio;
            mysqlCmd2.Parameters["@num_os"].Value = num_os;
            mysqlCmd2.Parameters["@travaux"].Value = "";
            mysqlCmd2.Parameters["@enlevement"].Value = -1;

            mysqlCmd2.ExecuteNonQuery();


            new_client = false;
          
            MessageBox.Show("Fiche crée");

            //mysqlCmd2 = new MySqlCommand("SELECT idfiche FROM fiche WHERE idclient = '" + id + "' ORDER BY idfiche DESC LIMIT 1", BaseDeDonnee.mysql);
            maRequete = "SELECT idfiche FROM fiche WHERE idclient = @id ORDER BY idfiche DESC LIMIT 1";
            mysqlCmd2 = new MySqlCommand(maRequete, BaseDeDonnee.mysql);
            mysqlCmd2.Parameters.Add(new MySqlParameter("@id", MySqlDbType.String));
            mysqlCmd2.Parameters["@id"].Value = id;
            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            numFiche = mysqlReader.GetInt32("idfiche").ToString();

            tabControl1.SelectTab(1);
            valeur_recherche.Text = numFiche;
            recherche.PerformClick();

            ResetCreationFiche();
            AfficheVueFiche();

            BaseDeDonnee.Deconnection();
        }

        // pour la saisie semi auto des clients.
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (!new_client)
            {
                BaseDeDonnee.Connection();
                string requete = "SELECT * FROM client WHERE nom LIKE @nom LIMIT 4";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
                mysqlCmd2.Parameters["@nom"].Value = nameBox.Text.Replace("'", "''")+"%";
               
                MySqlDataReader mysqlReader = mysqlCmd2.ExecuteReader();

                listClient.Items.Clear();

                while (mysqlReader.Read())
                {
                    listClient.Items.Add(mysqlReader.GetString("nom"));
                }

                if (listClient.Items.Count != 0 && nameBox.Text != "")
                    listClient.Show();
                else
                    listClient.Hide();

                mysqlReader.Close();
            }
            BaseDeDonnee.Deconnection();
        }

        // affiche ou non les elements lors de la création d'un nouveau client
        private void newClient_Click(object sender, EventArgs e)
        {
            new_client = !new_client;
            if (new_client)
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
            }
            else
            {
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
            }
            
        }

        //selection d'un client dans la liste proposée
        private void listClient_DoubleClick(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            string requete = "SELECT * FROM client WHERE nom LIKE @nom LIMIT 4";
            mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
            mysqlCmd2.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
            mysqlCmd2.Parameters["@nom"].Value = "%" + listClient.GetItemText(listClient.SelectedItem).Replace("'", "''") + "%";
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
            cpBox.Text = mysqlReader.GetString("cp"); ;
            mailBox.Text = mysqlReader.GetString("mail"); ;

            listClient.Hide();

            BaseDeDonnee.Deconnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                accessoiresBox.Text += " alimentation ";
            else
                accessoiresBox.Text = accessoiresBox.Text.Replace(" alimentation ", "");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                accessoiresBox.Text += " sacoche ";
            else
                accessoiresBox.Text = accessoiresBox.Text.Replace(" sacoche ", "");
        }


        #endregion

        #region ----- Création des Graphs pour les Stats -----

        /* Creation des stats concernant les OS */
        private void CreateGraphOS(ZedGraphControl zgc)
        {
            BaseDeDonnee.Connection();
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the Titles
            myPane.Title.Text = "Statistiques selon l'OS";
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsVisible = false;

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM os", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();


            String[] tabOS;
            float[] tabCount;
            int i = 1;
            mysqlReader.Read();
            int nbOs = mysqlReader.GetInt32(0) + 1;
            int totalOS = 0;

            tabOS = new String[nbOs];
            tabCount = new float[nbOs];

            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM os", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();
            while (mysqlReader.Read())
            {
                tabOS[i] = mysqlReader.GetString("nom_os");
                i++;
            }
            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabCount[mysqlReader.GetInt32("os")]++;
                totalOS++;
            }

            mysqlReader.Close();

            for (i = 1; i < nbOs; i++)
            {
                if(tabCount[i] > 0)
                    myPane.AddPieSlice(tabCount[i], Color.FromArgb(rndNumbers.Next(255), rndNumbers.Next(255), rndNumbers.Next(255)), 0, tabOS[i] + " (" + (tabCount[i] / totalOS * 100).ToString(".00") + "% - " + tabCount[i] + ")");
            }

            BaseDeDonnee.mysql.Close();
        }

        /* Creation des stats concernant l'Etat des fiches, à faire, terminée.... */
        private void CreateGraphEtat(ZedGraphControl zgc)
        {
            BaseDeDonnee.Connection();
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the Titles
            myPane.Title.Text = "Statistiques selon l'état";
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsVisible = false;

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM etat", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            String[] tabEtat;
            float[] tabCount;
            int i = 1;
            
            mysqlReader.Read();
            int nbEtats = mysqlReader.GetInt32(0) + 1;
            mysqlReader.Close();

            tabEtat = new String[nbEtats];
            tabCount = new float[nbEtats];
            int totalEtat = 0;
            mysqlCmd2 = new MySqlCommand("SELECT * FROM etat", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabEtat[i] = mysqlReader.GetString("nom_etat");
                i++;
            }
            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabCount[mysqlReader.GetInt32("etat")]++;
                totalEtat++;
            }

            mysqlReader.Close();
            for (i = 1; i < nbEtats; i++)
            {
                if (tabCount[i] > 0)
                    myPane.AddPieSlice(tabCount[i], Color.FromArgb(rndNumbers.Next(255), rndNumbers.Next(255), rndNumbers.Next(255)), 0, tabEtat[i] + " (" + (tabCount[i] / totalEtat * 100).ToString(".00") + "%"+ " - " + tabCount[i] + ")");
            }
            BaseDeDonnee.mysql.Close();
        }

        /* Création des stats concernant les marques traitées */
        private void CreateGraphMarque(ZedGraphControl zgc)
        {
            BaseDeDonnee.Connection();
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the Titles
            myPane.Title.Text = "Statistiques selon la marque";
            myPane.XAxis.IsVisible = false;
            myPane.YAxis.IsVisible = false;

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM marque", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            String[] tabMarque;
            float[] tabCount;
            int i = 1;
            int totalMarque = 0;

            mysqlReader.Read();
            int nbMarque = mysqlReader.GetInt32(0) + 1;
            mysqlReader.Close();

            tabMarque = new String[nbMarque];
            tabCount = new float[nbMarque];


            mysqlCmd2 = new MySqlCommand("SELECT * FROM marque", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();
            while (mysqlReader.Read())
            {
                tabMarque[i] = mysqlReader.GetString("nom_marque");
                i++;
            }
            mysqlReader.Close();

            mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche", BaseDeDonnee.mysql);
            mysqlReader = mysqlCmd2.ExecuteReader();

            while (mysqlReader.Read())
            {
                tabCount[mysqlReader.GetInt32("marque")]++;
                totalMarque++;
            }

            mysqlReader.Close();

            for (i = 1; i < nbMarque; i++)
            {
                if (tabCount[i] > 0)
                    myPane.AddPieSlice(tabCount[i], Color.FromArgb(rndNumbers.Next(255), rndNumbers.Next(255), rndNumbers.Next(255)), 0, tabMarque[i] + " (" + (tabCount[i] / totalMarque * 100).ToString(".00") + "%" + " - " + tabCount[i] + ")");
            }
            BaseDeDonnee.mysql.Close();
        }

        #endregion

        #region ----- Ouverture des fenetres du menu -----

        /* Click sur le menu Préférences */
        private void préférencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
            InitIpServeur();

            BaseDeDonnee.Connection();

            MaterielDataAdapter = new MySqlDataAdapter("select * from materiel", BaseDeDonnee.mysql);
            materielDataSet = new DataSet("materiel");
            MaterielDataAdapter.Fill(materielDataSet, "materiel");
            this.comboMatos.DataSource = materielDataSet.Tables["materiel"];
            this.comboMatos.ValueMember = "id_materiel";
            this.comboMatos.DisplayMember = "nom_materiel";
            comboMatos.Refresh();

            MarqueDataAdapter = new MySqlDataAdapter("select * from marque", BaseDeDonnee.mysql);
            MarqueDataSet = new DataSet("marque");
            MarqueDataAdapter.Fill(MarqueDataSet, "marque");
            this.MarqueList.DataSource = MarqueDataSet.Tables["marque"];
            this.MarqueList.ValueMember = "idmarque";
            this.MarqueList.DisplayMember = "nom_marque";
            MarqueList.Refresh();

            OSDataAdapter = new MySqlDataAdapter("select * from os", BaseDeDonnee.mysql);
            OSDataSet = new DataSet("os");
            OSDataAdapter.Fill(OSDataSet, "os");
            this.OSlist.DataSource = OSDataSet.Tables["os"];
            this.OSlist.ValueMember = "id_os";
            this.OSlist.DisplayMember = "nom_os";
            vf.comboBox2.DataSource = OSDataSet.Tables["os"];
            vf.comboBox2.ValueMember = "nom_os";
            vf.comboBox2.DisplayMember = "nom_os";
            vf.comboBox2.Refresh();
            OSlist.Refresh();


            ResetCreationFiche();
        }

        /* Click sur le menu Nouvelle Fiche */
        private void nouvelleFicheToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetCreationFiche();
            CreateGraphOS(graphOS);
            CreateGraphEtat(graphEtat);
            CreateGraphMarque(graphMarque);
            tabControl1.SelectedIndex = 0;
        }

        /* Click sur le menu Nouvelle marque */
        private void nouvelleMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouvelleMarque ajoutMarque = new NouvelleMarque();
            ajoutMarque.FormClosed += new FormClosedEventHandler(ajoutMarque_FormClosed);
            ajoutMarque.ShowDialog(this);
            
            
        }

        private void ajoutMarque_FormClosed(object sender, EventArgs e)
        {
            MarqueDataSet.Clear();
            MarqueDataAdapter.Fill(MarqueDataSet, "marque");
            MarqueList.Refresh();
        }

        /* Click sur le menu Nouvel Os */
        private void nouvelOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouvelOs ajoutOs = new NouvelOs();
            ajoutOs.FormClosed += new FormClosedEventHandler(ajoutOs_FormClosed);
            ajoutOs.ShowDialog(this);
        }

        private void ajoutOs_FormClosed(object sender, EventArgs e)
        {
            OSDataSet.Clear();
            OSDataAdapter.Fill(OSDataSet, "os");
            OSlist.Refresh();
        }

        /* Click sur le menu Nouveau Matériel */
        private void nouveauTypeDeMatérielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouveauType ajoutType = new NouveauType();
            ajoutType.FormClosed += new FormClosedEventHandler(ajoutType_FormClosed);
            ajoutType.ShowDialog(this);
        }

        private void ajoutType_FormClosed(object sender, EventArgs e)
        {
            materielDataSet.Clear();
            MaterielDataAdapter.Fill(materielDataSet, "materiel");
            comboMatos.Refresh();
        }

        /* Click sur le menu A propos de */
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AProposDe about = new AProposDe();
            about.ShowDialog(this);
        }

        /* Click sur le menu Quitter */
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mysqlReader.Close();
            BaseDeDonnee.mysql.Close();
            Environment.Exit(0);
        }

        #endregion

        #region ----- Onglet RECHERCHE SAV -----

        private void recherche_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            if (num_fiche.Checked == true && valeur_recherche.Text != "")
            {
                dataGridView1.Rows.Clear();

                string requete = "SELECT COUNT(*) FROM fiche WHERE idfiche = @idfiche";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@idfiche", MySqlDbType.String));
                mysqlCmd2.Parameters["@idfiche"].Value = valeur_recherche.Text;

                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();

                if (mysqlReader.GetInt32(0) > 0)
                {
                    mysqlReader.Close();
                    mysqlCmd2 = new MySqlCommand("SELECT * FROM fiche WHERE idfiche =" + valeur_recherche.Text, BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();

                    mysqlReader.Read();
                    int id_marque = mysqlReader.GetInt32("marque");
                    int id_client = mysqlReader.GetInt32("idclient");
                    String dateDepot = mysqlReader.GetString("date_depot");
                    String typeMateriel = mysqlReader.GetString("type_materiel");
                    String designation = mysqlReader.GetString("designation");
                    String accessoires = mysqlReader.GetString("accessoires");
                    String panne = mysqlReader.GetString("descriptif");
                    String etat = mysqlReader.GetString("etat");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT * FROM marque WHERE idmarque =" + id_marque , BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    String marque = mysqlReader.GetString("nom_marque");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT * FROM client WHERE idclient =" + id_client, BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    String nomClient = mysqlReader.GetString("nom");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT * FROM marque WHERE idmarque =" + id_marque, BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    marque = mysqlReader.GetString("nom_marque");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT * FROM materiel WHERE id_materiel =" + typeMateriel, BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    typeMateriel = mysqlReader.GetString("nom_materiel");
                    mysqlReader.Close();
                    //noFiche = false;
                    dataGridView1.Rows.Add(dateDepot, valeur_recherche.Text, nomClient, typeMateriel +" "+ marque +" "+ designation);
                    if (etat == "1")
                        dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Aquamarine;
                    else if (etat == "2" || (etat == "3") || (etat == "4"))
                        dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    else if (etat == "5")
                        dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LawnGreen;
                    else if (etat == "6")
                        dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Coral;

                    AfficheVueFiche();
                }
              /*  else
                {
                   // noFiche = true;
                }*/
            }
            else if (nom_client.Checked == true && valeur_recherche.Text != "")
            {
                int result;

                if (!int.TryParse(valeur_recherche.Text, out result) && valeur_recherche.Text != "")
                {
                    dataGridView1.Rows.Clear();
                    mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM client WHERE nom = \"" + valeur_recherche.Text + "\"", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    int existe = mysqlReader.GetInt32(0);
                    mysqlReader.Close();

                    if(existe != 0)
                    {
                        mysqlCmd2 = new MySqlCommand("SELECT idclient FROM client WHERE nom = \"" + valeur_recherche.Text+"\"", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
                        mysqlReader = mysqlCmd2.ExecuteReader();
                        mysqlReader.Read();
                        int idclient = mysqlReader.GetInt32(0);
                        mysqlReader.Close();

                        mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM client,fiche WHERE fiche.idclient =" + idclient + " AND client.idclient =" + idclient, BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
                        mysqlReader = mysqlCmd2.ExecuteReader();
                        mysqlReader.Read();
                        int nbCas = mysqlReader.GetInt32(0);

                        if (nbCas > 0)
                        {
                            mysqlReader.Close();
                            mysqlCmd2 = new MySqlCommand("SELECT fiche.idfiche, fiche.idclient, nom, date_depot, type_materiel, designation, accessoires, descriptif, marque, etat FROM client,fiche WHERE fiche.idclient =" + idclient + " AND client.idclient =" + idclient + " GROUP BY idfiche", BaseDeDonnee.mysql);
                            mysqlReader = mysqlCmd2.ExecuteReader();

                            String[,] tab = new String[nbCas, 10];
                            int i = 0;

                            while (mysqlReader.Read())
                            {
                                tab[i, 0] = mysqlReader.GetString("date_depot"); //date fiche
                                tab[i, 1] = mysqlReader.GetString("nom"); //nom du client
                                tab[i, 2] = mysqlReader.GetString("type_materiel"); //type de matos
                                tab[i, 3] = mysqlReader.GetString("marque"); //marque 
                                tab[i, 4] = mysqlReader.GetString("designation"); // modele
                                tab[i, 5] = mysqlReader.GetString("idfiche"); // id fiche
                                tab[i, 6] = mysqlReader.GetString("etat"); // etat fiche;
                                i++;
                            }
                            mysqlReader.Close();

                            for (i = 0; i < nbCas; i++) 
                            {
                                mysqlCmd2 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + tab[i, 3], BaseDeDonnee.mysql);
                                mysqlReader = mysqlCmd2.ExecuteReader();
                                mysqlReader.Read();
                                tab[i, 3] = mysqlReader.GetString("nom_marque");
                                mysqlReader.Close();
                            }

                            for (i = 0; i < nbCas; i++)
                            {
                                mysqlCmd2 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + tab[i, 2], BaseDeDonnee.mysql);
                                mysqlReader = mysqlCmd2.ExecuteReader();
                                mysqlReader.Read();
                                tab[i, 2] = mysqlReader.GetString("nom_materiel");
                                dataGridView1.Rows.Add(tab[i, 0], tab[i, 5], tab[i, 1], tab[i, 2] + " " + tab[i, 3] + " " + tab[i, 4]);
                                if (tab[i, 6] == "1")
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;
                                else if (tab[i, 6] == "2" || (tab[i, 6] == "3") || (tab[i, 6] == "4"))
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                else if (tab[i, 6] == "5")
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                                else if (tab[i, 6] == "6")
                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
                                mysqlReader.Close();
                            }
                            //noFiche = false;
                        }
                     /*   else
                        {
                            //noFiche = true;
                        }*/
                    }
                }
            }

            mysqlReader.Close();
            BaseDeDonnee.Deconnection();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            valeur_recherche.Text = listBox2.SelectedItem.ToString();
            listBox2.Hide();
        }

        private void valeur_recherche_TextChanged(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            string requete = "SELECT * FROM client WHERE nom LIKE @nom LIMIT 4";
            MySqlCommand mysqlCmd3 = new MySqlCommand(requete, BaseDeDonnee.mysql);
            mysqlCmd3.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
            mysqlCmd3.Parameters["@nom"].Value = valeur_recherche.Text.Replace("'", "''") + "%";

            MySqlDataReader mysqlReader2 = mysqlCmd3.ExecuteReader();

            //on efface la liste sinon les clients s'ajoute à la suite
            listBox2.Items.Clear();

            while (mysqlReader2.Read())
            {
                listBox2.Items.Add(mysqlReader2.GetString("nom"));
            }

            if (listBox2.Items.Count != 0 && !num_fiche.Checked && valeur_recherche.Text != "")
                listBox2.Show();
            else
                listBox2.Hide();

            mysqlReader2.Close();
            BaseDeDonnee.Deconnection();
        }
        //TODO: requete a refaire
        private void sToutes_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            dataGridView1.Rows.Clear();

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM fiche", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            int nbCas = mysqlReader.GetInt32(0);
            mysqlReader.Close();

            if (nbCas != 0)
            {

                mysqlReader.Close();
                mysqlCmd2 = new MySqlCommand("SELECT fiche.idfiche, fiche.idclient, date_depot, type_materiel, designation, accessoires, descriptif, marque, etat FROM fiche ORDER BY fiche.idfiche DESC", BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();

                String[,] tab = new String[nbCas, 10];
                int i = 0;

                while (mysqlReader.Read())
                {
                    tab[i, 0] = mysqlReader.GetString("date_depot"); //date fiche
                    tab[i, 1] = mysqlReader.GetString("idclient"); //nom du client
                    tab[i, 2] = mysqlReader.GetString("type_materiel"); //type de matos
                    tab[i, 3] = mysqlReader.GetString("marque"); //marque 
                    tab[i, 4] = mysqlReader.GetString("designation"); // modele
                    tab[i, 5] = mysqlReader.GetString("idfiche"); // id fiche
                    tab[i, 6] = mysqlReader.GetString("etat"); // etat fiche;

                    i++;
                }
                mysqlReader.Close();

                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + tab[i, 3], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 3] = mysqlReader.GetString("nom_marque");
                    mysqlReader.Close();
                }


                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom FROM client WHERE idclient =" + tab[i, 1], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 1] = mysqlReader.GetString("nom");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + tab[i, 2], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 2] = mysqlReader.GetString("nom_materiel");
                    dataGridView1.Rows.Add(tab[i, 0], tab[i, 5], tab[i, 1], tab[i, 2] + " " + tab[i, 3] + " " + tab[i, 4]);
                    if (tab[i, 6] == "1")
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;
                    else if (tab[i, 6] == "2" ||  (tab[i, 6] == "3") ||  (tab[i, 6] == "4"))
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    else if (tab[i, 6] == "5")
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                    else if (tab[i, 6] == "6")
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
                    mysqlReader.Close();
                }
                //noFiche = false;
            }
          /*  else
            {
                //noFiche = true;
            }*/
            BaseDeDonnee.Deconnection();
        }
        //TODO: requete a refaire
        private void sAfaire_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            dataGridView1.Rows.Clear();

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM fiche WHERE etat = 1", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            int nbCas = mysqlReader.GetInt32(0);
            mysqlReader.Close();

            if (nbCas != 0)
            {
                    mysqlReader.Close();
                    mysqlCmd2 = new MySqlCommand("SELECT fiche.idfiche, fiche.idclient, date_depot, type_materiel, designation, accessoires, descriptif, marque FROM fiche WHERE fiche.etat = 1  ORDER BY fiche.idfiche DESC", BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();

                    String[,] tab = new String[nbCas, 10];
                    int i = 0;

                    while (mysqlReader.Read())
                    {
                        tab[i, 0] = mysqlReader.GetString("date_depot"); //date fiche
                        tab[i, 1] = mysqlReader.GetString("idclient"); //nom du client
                        tab[i, 2] = mysqlReader.GetString("type_materiel"); //type de matos
                        tab[i, 3] = mysqlReader.GetString("marque"); //marque 
                        tab[i, 4] = mysqlReader.GetString("designation"); // modele
                        tab[i, 5] = mysqlReader.GetString("idfiche"); // id fiche
                        i++;
                    }
                    mysqlReader.Close();

                    for (i = 0; i < nbCas; i++)
                    {
                        mysqlCmd2 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + tab[i, 3], BaseDeDonnee.mysql);
                        mysqlReader = mysqlCmd2.ExecuteReader();
                        mysqlReader.Read();
                        tab[i, 3] = mysqlReader.GetString("nom_marque");
                        mysqlReader.Close();
                    }


                    for (i = 0; i < nbCas; i++)
                    {
                        mysqlCmd2 = new MySqlCommand("SELECT nom FROM client WHERE idclient =" + tab[i, 1], BaseDeDonnee.mysql);
                        mysqlReader = mysqlCmd2.ExecuteReader();
                        mysqlReader.Read();
                        tab[i, 1] = mysqlReader.GetString("nom");
                        mysqlReader.Close();

                        mysqlCmd2 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + tab[i, 2], BaseDeDonnee.mysql);
                        mysqlReader = mysqlCmd2.ExecuteReader();
                        mysqlReader.Read();
                        tab[i, 2] = mysqlReader.GetString("nom_materiel");
                        dataGridView1.Rows.Add(tab[i, 0], tab[i, 5], tab[i, 1], tab[i, 2] + " " + tab[i, 3] + " " + tab[i, 4]);
                        mysqlReader.Close();
                    }
                    //noFiche = false;
                }
            /*    else
                {
                    //noFiche = true;
                }*/
            BaseDeDonnee.Deconnection();
        }
        //TODO: requete a refaire
        private void sAttente_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            dataGridView1.Rows.Clear();

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM fiche WHERE etat = 2 OR etat = 3 OR etat = 4 OR etat = 5", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            int nbCas = mysqlReader.GetInt32(0);
            mysqlReader.Close();

            if (nbCas != 0)
            {

                mysqlReader.Close();
                mysqlCmd2 = new MySqlCommand("SELECT fiche.idfiche, fiche.idclient, date_depot, type_materiel, designation, accessoires, descriptif, marque FROM fiche WHERE etat = 2 OR etat = 3 OR etat = 4 OR etat = 5 ORDER BY fiche.idfiche DESC", BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();

                String[,] tab = new String[nbCas, 10];
                int i = 0;

                while (mysqlReader.Read())
                {
                    tab[i, 0] = mysqlReader.GetString("date_depot"); //date fiche
                    tab[i, 1] = mysqlReader.GetString("idclient"); //nom du client
                    tab[i, 2] = mysqlReader.GetString("type_materiel"); //type de matos
                    tab[i, 3] = mysqlReader.GetString("marque"); //marque 
                    tab[i, 4] = mysqlReader.GetString("designation"); // modele
                    tab[i, 5] = mysqlReader.GetString("idfiche"); // id fiche
                    i++;
                }
                mysqlReader.Close();

                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + tab[i, 3], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 3] = mysqlReader.GetString("nom_marque");
                    mysqlReader.Close();
                }

                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom FROM client WHERE idclient =" + tab[i, 1], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 1] = mysqlReader.GetString("nom");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + tab[i, 2], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 2] = mysqlReader.GetString("nom_materiel");
                    dataGridView1.Rows.Add(tab[i, 0], tab[i, 5], tab[i, 1], tab[i, 2] + " " + tab[i, 3] + " " + tab[i, 4]);
                    mysqlReader.Close();
                }
                //noFiche = false;
            }
        /*    else
            {
                //noFiche = true;
            }*/
            BaseDeDonnee.Deconnection();
        }
        //TODO: requete a refaire
        private void sTerminee_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();
            dataGridView1.Rows.Clear();

            mysqlCmd2 = new MySqlCommand("SELECT COUNT(*) FROM fiche WHERE etat = 6", BaseDeDonnee.mysql); // pour vérifier qu'il existe bien un résultat
            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();
            int nbCas = mysqlReader.GetInt32(0);
            mysqlReader.Close();

            if (nbCas != 0)
            {

                mysqlReader.Close();
                mysqlCmd2 = new MySqlCommand("SELECT fiche.idfiche, fiche.idclient, date_depot, type_materiel, designation, accessoires, descriptif, marque FROM fiche WHERE fiche.etat = 6  ORDER BY fiche.idfiche DESC", BaseDeDonnee.mysql);
                mysqlReader = mysqlCmd2.ExecuteReader();

                String[,] tab = new String[nbCas, 10];
                int i = 0;

                while (mysqlReader.Read())
                {
                    tab[i, 0] = mysqlReader.GetString("date_depot"); //date fiche
                    tab[i, 1] = mysqlReader.GetString("idclient"); //nom du client
                    tab[i, 2] = mysqlReader.GetString("type_materiel"); //type de matos
                    tab[i, 3] = mysqlReader.GetString("marque"); //marque 
                    tab[i, 4] = mysqlReader.GetString("designation"); // modele
                    tab[i, 5] = mysqlReader.GetString("idfiche"); // id fiche

                    i++;
                }
                mysqlReader.Close();

                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom_marque FROM marque WHERE idmarque =" + tab[i, 3], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 3] = mysqlReader.GetString("nom_marque");
                    mysqlReader.Close();
                }

                for (i = 0; i < nbCas; i++)
                {
                    mysqlCmd2 = new MySqlCommand("SELECT nom FROM client WHERE idclient =" + tab[i, 1], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 1] = mysqlReader.GetString("nom");
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("SELECT nom_materiel FROM materiel WHERE id_materiel =" + tab[i, 2], BaseDeDonnee.mysql);
                    mysqlReader = mysqlCmd2.ExecuteReader();
                    mysqlReader.Read();
                    tab[i, 2] = mysqlReader.GetString("nom_materiel");
                    dataGridView1.Rows.Add(tab[i, 0], tab[i, 5], tab[i, 1], tab[i, 2] + " " + tab[i, 3] + " " + tab[i, 4]);
                    mysqlReader.Close();
                }


                //noFiche = false;
            }
          /*  else
            {
                //noFiche = true;
            }*/
            BaseDeDonnee.Deconnection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            AfficheVueFiche();
        }

        #endregion

        #region ----- Onglet RECHERCHER CLIENT -----

        private void rcValider_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            string requete = "UPDATE client SET nom = @nom, adresse = @adresse, cp = @cp, ville = @ville, tel1 = @tel1, tel2 = @tel2, mail = @mail WHERE idclient = @id";
            mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
            mysqlCmd2.Parameters.Add(new MySqlParameter("@id", MySqlDbType.String));
            mysqlCmd2.Parameters["@id"].Value = idClientRecherche;
            mysqlCmd2.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
            mysqlCmd2.Parameters["@nom"].Value = rechercheClient.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@adresse", MySqlDbType.String));
            mysqlCmd2.Parameters["@adresse"].Value = rcAdresse.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@cp", MySqlDbType.String));
            mysqlCmd2.Parameters["@cp"].Value = rcCP.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@ville", MySqlDbType.String));
            mysqlCmd2.Parameters["@ville"].Value = rcVille.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@tel1", MySqlDbType.String));
            mysqlCmd2.Parameters["@tel1"].Value = rcTel1.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@tel2", MySqlDbType.String));
            mysqlCmd2.Parameters["@tel2"].Value = rcTel2.Text.Replace("'", "''");
            mysqlCmd2.Parameters.Add(new MySqlParameter("@mail", MySqlDbType.String));
            mysqlCmd2.Parameters["@mail"].Value = rcMail.Text.Replace("'", "''");

            mysqlReader = mysqlCmd2.ExecuteReader();
            mysqlReader.Read();

            BaseDeDonnee.Deconnection();

            MessageBox.Show("Informations du client mis à jour");
        }

        private void rcSupprimer_Click(object sender, EventArgs e)
        {
            string nomC = rechercheClient.Text.Replace("'", "''");
            if (DialogResult.Yes == MessageBox.Show("Voulez vous supprimer ce client ?", "Suppression d'un client", MessageBoxButtons.YesNo))
            {
                if (nomC != "")
                {
                    BaseDeDonnee.Connection();

                    string requete = "SELECT idclient FROM client WHERE nom = @nom";
                    MySqlCommand mysqlCmd3 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                    mysqlCmd3.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
                    mysqlCmd3.Parameters["@nom"].Value = nomC;
                    mysqlReader = mysqlCmd3.ExecuteReader();
                    mysqlReader.Read();
                    int idclient = mysqlReader.GetInt32(0);
                    mysqlReader.Close();

                    mysqlCmd2 = new MySqlCommand("DELETE FROM client WHERE idclient = " + idclient, BaseDeDonnee.mysql);
                    mysqlCmd2.ExecuteNonQuery();

                    BaseDeDonnee.Deconnection();

                    rcNom.Text = "";
                    rcAdresse.Text = "";
                    rcVille.Text = "";
                    rcCP.Text = "";
                    rcMail.Text = "";
                    rcTel1.Text = "";
                    rcTel2.Text = "";
                }
            }
        }

        private void rechercheClient_TextChanged(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            string requete = "SELECT * FROM client WHERE nom LIKE @nom LIMIT 4";
            MySqlCommand mysqlCmd3 = new MySqlCommand(requete, BaseDeDonnee.mysql);
            mysqlCmd3.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
            mysqlCmd3.Parameters["@nom"].Value = rechercheClient.Text.Replace("'", "''") + "%";

            MySqlDataReader mysqlReader2 = mysqlCmd3.ExecuteReader();

            //on efface la liste sinon les clients s'ajoute à la suite
            listBox1.Items.Clear();

            while (mysqlReader2.Read())
            {
                listBox1.Items.Add(mysqlReader2.GetString("nom"));
            }

            if (listBox1.Items.Count != 0 && rechercheClient.Text != "")
                listBox1.Show();
            else
                listBox1.Hide();

            mysqlReader2.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != "")
            {
                rechercheClient.Text = listBox1.SelectedItem.ToString();
                listBox1.Hide();
                clientExiste = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BaseDeDonnee.Connection();

            if (rechercheClient.Text != "" && clientExiste)
            {
                string requete = "SELECT * FROM client WHERE nom = @nomClient";
                mysqlCmd2 = new MySqlCommand(requete, BaseDeDonnee.mysql);
                mysqlCmd2.Parameters.Add(new MySqlParameter("@nomClient", MySqlDbType.String));
                mysqlCmd2.Parameters["@nomClient"].Value = rechercheClient.Text;
                mysqlReader = mysqlCmd2.ExecuteReader();
                mysqlReader.Read();

                idClientRecherche = mysqlReader.GetInt32("idclient");
                rcNom.Text = mysqlReader.GetString("nom");
                rcAdresse.Text = mysqlReader.GetString("adresse");
                rcCP.Text = mysqlReader.GetString("cp");
                rcVille.Text = mysqlReader.GetString("ville");
                rcTel1.Text = mysqlReader.GetString("tel1");
                rcTel2.Text = mysqlReader.GetString("tel2");
                rcMail.Text = mysqlReader.GetString("mail");
                mysqlReader.Close();
                clientExiste = false;
            }
        }

        #endregion
        
    }
}
