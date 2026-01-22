using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Client
    {
        private int idCL;

        public int IdCL
        {
            get { return idCL; }
            set { idCL = value; }
        }
        private string nomCl;

        public string NomCl
        {
            get { return nomCl; }
            set { nomCl = value; }
        }
        private string adressCL;

        public string AdressCL
        {
            get { return adressCL; }
            set { adressCL = value; }
        }
    }
}