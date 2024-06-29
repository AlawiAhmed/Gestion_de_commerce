using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_continue
{
   public class Avocat
    {
        private int MatriculeAvocat;
        private string nom;
        private string prenom;

       
        public Avocat() { }
        public Avocat (int m,string n,string p)
        {
            this.MatriculeAvocat1 = m;
            this.Nom = n;
            this.Prenom = p;
        }

        public int MatriculeAvocat1
        {
            get
            {
                return MatriculeAvocat;
            }

            set
            {
                MatriculeAvocat = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Matricule : {0}\nNom : {1}\nPrenom : {2}", MatriculeAvocat, nom, prenom);
        }
    }
}
