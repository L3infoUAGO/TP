using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Fournisseur
    {
        public int Id
        {
            get;
        }
        public string Nom
        {
            get;
        }
        public string Adresse
        {
            get;
        }
        public string Telephone
        {
            get;
        }
        public string Email
        {
            get;
            set;
        }
    }
}