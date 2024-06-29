using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_continue
{
   public class DossierAffaireImmobilière :Dossier
    {
        double frai_notaire;
        public DossierAffaireImmobilière() : base() { }
        public DossierAffaireImmobilière(double frai_notaire, int n, Client c, DateTime d, DateTime dj, double ch, string e) : base(n, c, d, dj, ch, e)
        {
            this.frai_notaire = frai_notaire;
        }

        public double Frai_notaire
        {
            get
            {
                return frai_notaire;
            }

            set
            {
                frai_notaire = value;
            }
        }
        public override double CalculerHonoraireAvocat()
        {
            return ((Charge + frai_notaire) / DuréeTraitementDossier());
        }
    }
}
