using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Penalty
    {
        public int Id
        {
            get;
        }
        public string joueur
        {
            get;
        }
        public string numero
        {
            get;
        }
        public string penaltyTires
        {
            get;
        }
        public string penaltyMarques
        {
            get;
            set;
        }
    }
}