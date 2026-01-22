using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class ELECTRICITE
    {
        private string idElecm;

        public string IdElecm
        {
            get { return idElecm; }
            set { idElecm = value; }
        }
        private string design;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }
    }
}