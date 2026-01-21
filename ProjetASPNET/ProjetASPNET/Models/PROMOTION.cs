using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class PROMOTION
    {
        private string idProm;

        public string IdProm
        {
            get { return idProm; }
            set { idProm = value; }
        }
        private string desProm;

        public string DesProm
        {
            get { return desProm; }
            set { desProm = value; }
        }
        private string nomProm;

        public string NomProm
        {
            get { return nomProm; }
            set { nomProm = value; }
        }
    }
}