using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class faculte
    {
        private int idfac;

        public int Idfac
        {
            get { return idfac; }
            set { idfac = value; }
        }
        private string nomfac;


        public string Nomfac
        {
            get { return nomfac; }
            set { nomfac = value; }
        }
        private string designfac;

        public string Designfac
        {
            get { return designfac; }
            set { designfac = value; }
        }
    }
}