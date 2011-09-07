using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FicheSAV
{

    public class Fiche
    {
        private string num;
        private string date;
        private string pwd;

        private string accessoires;
        private string panne;

        private string travaux_fiche;
        private string type_enlevement;
        private string etat;
        private string reprisLe;

        Client c = null;
        Materiel m = null;


        public Fiche()
        {
            num = "0";
            date = "";
            pwd = "";
         
            accessoires = "";
            panne = "";
            travaux_fiche = "";
            type_enlevement = "";
            etat = "";

            reprisLe = "";
            
            c = new Client();
            m = new Materiel();
        }

        public Fiche(string num, string dateD, string password, Client cl, string type, string marque, string modele, string accessoire, string panneMachine, string travaux, string types_enlevement, string etatDeFiche, string repris)
        {
            numFiche = num;
            date = dateD;
            pwd = password;

            c.nomClient = cl.nomClient;
            c.tel1Client = cl.tel1Client;
            c.tel2Client = cl.tel2Client;
            c.adresseClient = cl.adresseClient;
            c.cpClient = cl.cpClient;
            c.villeClient = cl.villeClient;
           
            m.type = type;
            m.marque = marque;
            m.modele = modele;
            accessoires = accessoire;
            panne = panneMachine;

            travaux_fiche = travaux;
            type_enlevement = types_enlevement;

            etat = etatDeFiche;

            reprisLe = repris;

            c = new Client();
            m = new Materiel();
        }


        public string numFiche
        {
            get { return num; }
            set { num = value; }
        }

        public string dateDepot
        {
            get { return date; }
            set { date = value; }
        }

        public string pass
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public string accessoire
        {
            get { return accessoires; }
            set { accessoires = value; }
        }

        public string panneMateriel
        {
            get { return panne; }
            set { panne = value; }
        }

        public string etatFiche
        {
            get { return etat; }
            set { etat = value; }
        }

        public string reprise
        {
            get { return reprisLe; }
            set { reprisLe = value; }
        }

        public string travaux
        {
            get { return travaux_fiche; }
            set { travaux_fiche = value; }
        }

        public string typeEnlevement
        {
            get { return type_enlevement; }
            set { type_enlevement = value; }
        }

        public Client client
        {
            get { return c; }
            set { c = value; }
        }

        public Materiel materiel
        {
            get { return m; }
            set { m = value; }
        }
    }
}
