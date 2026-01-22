using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Entreprise
    {
        private string nomEnt;

        public string NomEnt
        {
            get { return nomEnt; }
            set { nomEnt = value; }
        }
        private string designEnt;

        public string DesignEnt
        {
            get { return designEnt; }
            set { designEnt = value; }
        }
    }
}