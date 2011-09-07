using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FicheSAV
{
    class BaseDeDonnee
    {
        public MySqlConnection mysql;

        public void Connection()
        {
            mysql = new MySqlConnection("datasource=192.168.1.15;username=root;password='';database=SAV");
            try
            {
                mysql.Open();
            }
            catch (Exception ex)
            {     
                MessageBox.Show("Impossible de se connecter au serveur\n" + "Code erreur : "+ex.Message);
            }
        }


        public void Deconnection()
        {
            mysql.Dispose();
            mysql.Close();
        }


    }
}
