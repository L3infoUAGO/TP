using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Voiture
    {
   
        public int IdVoiture
        {
            get;
        }
        public string MarqueVoiture
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