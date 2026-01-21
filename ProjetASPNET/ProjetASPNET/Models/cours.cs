using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class cours
    {
        private string codeCours;

        public string CodeCours
        {
            get { return codeCours; }
            set { codeCours = value; }
        }
        private string designCours;

        public string DesignCours
        {
            get { return designCours; }
            set { designCours = value; }
        }
        private int nbreCred;

        public int NbreCred
        {
            get { return nbreCred; }
            set { nbreCred = value; }
        }

        public cours()
        { 
        }
        public cours(string code, string des, int nbre)
        {
            this.codeCours = code;
            this.designCours = des;
            this.nbreCred = nbre;
        }

    }
}