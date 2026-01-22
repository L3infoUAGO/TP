using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Connexion
    {
        private int UserID;

        public int UserID1
        {
            get { return UserID; }
            set { UserID = value; }
        }
        private string Password;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }
        private string InitialCatalog;

        public string InitialCatalog1
        {
            get { return InitialCatalog; }
            set { InitialCatalog = value; }
        }
        private decimal IntegratedSecurity;

        public decimal IntegratedSecurity1
        {
            get { return IntegratedSecurity; }
            set { IntegratedSecurity = value; }
        }
        private int Quantite;

        public int Quantite1
        {
            get { return Quantite; }
            set { Quantite = value; }
        }
    }
}




