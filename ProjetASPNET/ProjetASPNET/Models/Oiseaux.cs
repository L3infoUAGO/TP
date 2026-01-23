using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Oiseaux
    { private string designOiseau;

    public string designOiseau
        {
            get { return designOiseau; }
            set { designOiseau = value; }
        }

        public Oiseaux()
        {
        }

        public Oiseaux(string des)
        {
            this.designOiseau = des;
        }
        }
    }

   