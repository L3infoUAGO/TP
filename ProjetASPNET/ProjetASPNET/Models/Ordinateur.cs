using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Ordinateur
    {
        public int IdOrdi
        {
            get;
        }
        public string Marque
        {
            get;
        }
        public string capOrdi
        {
            get;
        }

        public string Prix
        {
            get;
            set;
        }
    }
}