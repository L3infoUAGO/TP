using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Produits
    {

        public int Id_Produit
        {
            get;
        }
        public string NomProduit
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