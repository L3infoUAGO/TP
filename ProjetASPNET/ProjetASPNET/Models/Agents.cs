using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

namespace ProjetASPNET.Models
{
    public class Agents
    {
        private int IdAgent1;

        public int IdAgent11
        {
            get { return IdAgent1; }
            set { IdAgent1 = value; }
        }
        private string NomAgent1;

        public string NomAgent11
        {
            get { return NomAgent1; }
            set { NomAgent1 = value; }
        }
        private string PrenomAgent1;

        public string PrenomAgent11
        {
            get { return PrenomAgent1; }
            set { PrenomAgent1 = value; }
        }
        private string Fonction1;

        public string Fonction11
        {
            get { return Fonction1; }
            set { Fonction1 = value; }
        }
        private decimal Salaire1;

        public decimal Salaire11
        {
            get { return Salaire1; }
            set { Salaire1 = value; }
        }
    }
}
