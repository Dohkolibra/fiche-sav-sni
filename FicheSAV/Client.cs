using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FicheSAV
{
    public class Client
    {
        private string idC = "";
        private string nomC = "";
        private string tel1C = "";
        private string tel2C = "";
        private string adresseC = "";
        private string cpC = "";
        private string villeC = "";



        public Client()
        {
            idC = "";
            nomC = "";
            tel1C = "";
            tel2C = "";
            adresseC = "";
            cpC = "";
            villeC = "";
        }

        public Client(string id, string nom, string tel1, string tel2, string adresse, string cp, string ville)
        {
            idC = id;
            nomC = nom;
            tel1C = tel1;
            tel2C = tel2;
            adresseC = adresse;
            cpC = cp;
            villeC = ville;
        }

        public string idClient
        {
            get { return idC; }
            set { idC = value; }
        }

        public string nomClient
        {
            get { return nomC; }
            set { nomC = value; }
        }

        public string tel1Client
        {
            get { return tel1C; }
            set { tel1C = value; }
        }

        public string tel2Client
        {
            get { return tel2C; }
            set { tel2C = value; }
        }

        public string adresseClient
        {
            get { return adresseC; }
            set { adresseC = value; }
        }

        public string cpClient
        {
            get { return cpC; }
            set { cpC = value; }
        }

        public string villeClient
        {
            get { return villeC; }
            set { villeC = value; }
        } 

    }
}
