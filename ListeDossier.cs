using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace controle_continue
{
    [Serializable]
    public class ListeDossier
    {
        List<Dossier> l_d;
        public ListeDossier() { }
        public ListeDossier(List<Dossier> l_d)
        {
            this.L_d = l_d;
        }

        public List<Dossier> L_d
        {
            get
            {
                return l_d;
            }

            set
            {
                l_d = value;
            }
        }
        public void Ajouter(Dossier d)
        {
            bool ex = false;
            foreach (Dossier d1 in l_d)
            {
                if (d1.Numero_dossier.Equals(d.Numero_dossier))
                {
                    throw new Exception("ce compte deja exsite");
                    ex = true;

                }
            }
            if (ex == false)
            {
                l_d.Add(d);
            }
        }
        public void Supprimer(int numero)
        {


            l_d.RemoveAll(i => i.Numero_dossier == numero);
        }

        public List<Dossier> ListeDossiers(int numero_dossier)
        {
            List<Dossier> l_compteClient = new List<Dossier>();
            foreach (Dossier c in l_compteClient)
            {
                if (c.Cl.Num_client == numero_dossier)
                {
                    l_compteClient.Add(c);
                }
            }
            return l_compteClient;
        }

        public List<DossierAffaireCriminelle> ListeDossierAffaireCriminelle()
        {
            List<DossierAffaireCriminelle> L_DossierAffaireCriminelle = new List<DossierAffaireCriminelle>();
            foreach (Dossier c in l_d)
            {
                if (c is DossierAffaireCriminelle)
                {
                    L_DossierAffaireCriminelle.Add((DossierAffaireCriminelle)c);
                }
            }
            return L_DossierAffaireCriminelle;





        }

        public List<DossierAffaireImmobilière> ListeDossierAffaireImmobilière()
        {
            List<DossierAffaireImmobilière> L_DossierAffaireImmobilière = new List<DossierAffaireImmobilière>();
            foreach (Dossier c in l_d)
            {
                if (c is DossierAffaireCriminelle)
                {
                    L_DossierAffaireImmobilière.Add((DossierAffaireImmobilière)c);
                }
            }
            return L_DossierAffaireImmobilière;

        }


        public void Sauvgarder(string chemin)
        {
            FileStream f = new FileStream(chemin, FileMode.OpenOrCreate);
            XmlSerializer xm = new XmlSerializer(typeof(List<Dossier>));
            xm.Serialize(f, l_d);
            f.Close();
        }
    }
}
