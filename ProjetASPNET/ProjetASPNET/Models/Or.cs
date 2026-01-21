using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Or
    {
        private int idor;

        public int Idor
        {
            get { return idor; }
            set { idor = value; }
        }
        private String designationor;

        public String Designationor
        {
            get { return designationor; }
            set { designationor = value; }
        }
        private String quantiteor;

        public String Quantiteor
        {
            get { return quantiteor; }
            set { quantiteor = value; }
        }
        private String qualiteor;

        public String Qualiteor
        {
            get { return qualiteor; }
            set { qualiteor = value; }
        }
        private String destinationor;

        public String Destinationor
        {
            get { return destinationor; }
            set { destinationor = value; }
        }
    }

}