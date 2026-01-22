using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Professeur
    {
        private int matriPr;

        public int MatriPr
        {
            get { return matriPr; }
            set { matriPr = value; }
        }
        private string nomPr;

        public string NomPr
        {
            get { return nomPr; }
            set { nomPr = value; }
        }
        private string postnomPr;

        public string PostnomPr
        {
            get { return postnomPr; }
            set { postnomPr = value; }
        }
        private string prenomPr;

        public string PrenomPr
        {
            get { return prenomPr; }
            set { prenomPr = value; }
        }
    }
}