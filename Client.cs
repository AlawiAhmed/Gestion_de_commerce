using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_continue
{
   public class Client
    {
        private static int auto;
        private int num_client;
        private string nom;
        private string prenom;
        private Avocat avocat_traitant;

        public int Num_client
        {
            get
            {
                return num_client;
            }

            set
            {
                num_client = value;
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

        internal Avocat Avocat_traitant
        {
            get
            {
                return avocat_traitant;
            }

            set
            {
                avocat_traitant = value;
            }
        }

        public Client()
        {
            auto++;
            this.Num_client = auto;
        }
        public Client(string n,string p,Avocat av):this()
        {
           
            this.Nom = n;
            this.Prenom = p;
            this.Avocat_traitant = av;
        }

        public override string ToString()
        {
            return string.Format("N° Client : {0}\nNom : {1}\nPrenom : {2}\nAvocat Trainement : {3}", num_client, nom, prenom, avocat_traitant.ToString());
        }

    }
}
