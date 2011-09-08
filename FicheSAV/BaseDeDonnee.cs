using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FicheSAV
{
    public static class BaseDeDonnee
    {
        public static MySqlConnection mysql;
        static string Ip;

        public static void Connection()
        {
            if(Ip == null)
                Ip = "127.0.0.1";

            mysql = new MySqlConnection("datasource=" + Ip + ";username=root;password='';database=sav");
            try
            {
                mysql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter au serveur "+Ip +"\n" + "Code erreur : " + ex.Message);
            }
        }


        public static void Connection(string Ip)
        {
            mysql = new MySqlConnection("datasource="+ Ip +";username=root;password='';database=SAV");
            try
            {
                mysql.Open();
            }
            catch (Exception ex)
            {     
                MessageBox.Show("Impossible de se connecter au serveur\n" + "Code erreur : "+ex.Message);
            }
        }


        public static void Deconnection()
        {
            mysql.Dispose();
            mysql.Close();
        }

        public static string AdIp
        {
            get { return Ip; }
            set { Ip = value; }
        }

    }
}
