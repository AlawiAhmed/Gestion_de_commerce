using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_continue
{
  public abstract class Dossier
    {
        int numero_dossier;
        Client cl;
        DateTime date_ouve;
        DateTime date_juj;
        double charge;
        string etat;


        public Dossier() { }
        public Dossier(int numero_dossier, Client cl, DateTime date_ouve, DateTime date_juj, double charge, string etat)
        {
            this.numero_dossier = numero_dossier;
            this.cl = cl;
            this.date_ouve = date_ouve;
            this.date_juj = date_juj;
            this.charge = charge;
            this.etat = etat;
        }

        public int Numero_dossier
        {
            get
            {
                return numero_dossier;
            }

            set
            {
                numero_dossier = value;
            }
        }

        internal Client Cl
        {
            get
            {
                return cl;
            }

            set
            {
                cl = value;
            }
        }

        public DateTime Date_ouve
        {
            get
            {
                return date_ouve;
            }

            set
            {
                date_ouve = value;
            }
        }

        public DateTime Date_juj
        {
            get
            {
                return date_juj;
            }

            set
            {
                if(value < DateTime.Today) throw new Exception("date de juj doit etre supérieur a la date du jour");
                    else date_juj = value;
               
            }
        }

        public double Charge
        {
            get
            {
                return charge;
            }

            set
            {
                charge = value;
            }
        }

        public string Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }
        public abstract double CalculerHonoraireAvocat();

       public int DuréeTraitementDossier()
        {
            return  DateTime.Today.Year - date_juj.Year;
        }



    }
}
