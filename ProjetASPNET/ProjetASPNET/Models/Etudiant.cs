using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASPNET.Models
{
    public class Etudiant
    {
        private int matEt;

        public int MatEt
        {
            get { return matEt; }
            set { matEt = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string postnom;

        public string Postnom
        {
            get { return postnom; }
            set { postnom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public Etudiant()
        {
        }
        public Etudiant(int mat, string nom, string post, string pre)
        {
            this.matEt = mat;
            this.nom = nom;
            this.postnom = post;
            this.prenom = pre;
        }
    }
}