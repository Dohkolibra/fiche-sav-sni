using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FicheSAV
{

    public class Materiel
    {
        private string _typeMateriel;
        private string _marqueMateriel;
        private string _modeleMateriel;
        private string _os;


        public Materiel()
        {
            _typeMateriel = "";
            _marqueMateriel = "";
            _modeleMateriel = "";
            _os = "";

        }

        public Materiel(string typeMateriel, string marqueMateriel, string modeleMateriel, string os)
        {
            _typeMateriel = typeMateriel;
            _marqueMateriel = marqueMateriel;
            _modeleMateriel = modeleMateriel;
            _os = os;
        }


        public string type
        {
            get { return _typeMateriel; }
            set { _typeMateriel = value; }
        }

        public string marque
        {
            get { return _marqueMateriel; }
            set { _marqueMateriel = value; }
        }

        public string modele
        {
            get { return _modeleMateriel; }
            set { _modeleMateriel = value; }
        }

        public string os
        {
            get { return _os; }
            set { _os = value; }
        }

    }
}
