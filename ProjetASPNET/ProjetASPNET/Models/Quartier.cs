using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Quartier
    {
        private string designQuart;

        public string DesignQuart
        {
            get { return designQuart; }
            set { designQuart = value; }
        }

        public Quartier()
        {
        }

        public Quartier(string des)
        {
            this.designQuart = des;
        }
    }
}