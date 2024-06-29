using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_continue
{
   public class DossierAffaireCriminelle :Dossier
    {
        double pourcentage;
        public DossierAffaireCriminelle() : base() { }
        public DossierAffaireCriminelle(double pourcentage, int n, Client c, DateTime d, DateTime dj, double ch, string e) :base(n,c,d,dj,ch,e)
        {
            this.pourcentage = pourcentage;
        }

        public double Pourcentage
        {
            get
            {
                return pourcentage;
            }

            set
            {
                pourcentage = value;
            }
        }

        public override double CalculerHonoraireAvocat()
        {
            return (Charge / DuréeTraitementDossier()) * pourcentage;
        }
    }
}
