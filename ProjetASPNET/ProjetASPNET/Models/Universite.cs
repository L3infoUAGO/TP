using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Universite
    {
        private string codeUniversite;

        public string CodeUniversite
        {
            get { return codeUniversite; }
            set { codeUniversite = value; }
        }

        private string nomUniversite;

        public string NomUniversite
        {
            get { return nomUniversite; }
            set { nomUniversite = value; }
        }

        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string pays;

        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        // Constructeur vide
        public Universite()
        {
        }

        // Constructeur avec paramètres
        public Universite(string code, string nom, string ville, string pays)
        {
            this.codeUniversite = code;
            this.nomUniversite = nom;
            this.ville = ville;
            this.pays = pays;
        }
    }

}