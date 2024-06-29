using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace controle_continue
{

    public partial class Figures4 : Form
    {

        public Figures4()
        {
            InitializeComponent();
        }
        List<Dossier> l_d = new List<Dossier>();
        int indice = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dp.HeaderText = "Pourcentage Avocat";
                dataaa.Rows.Clear();

                foreach (DossierAffaireCriminelle cp in Form1.lccc.ListeDossierAffaireCriminelle())
                {
                    dataaa.Rows.Add(cp.Charge, cp.Date_juj, cp.Date_ouve, cp.Cl.Nom, cp.Cl.Prenom, cp.Etat);
                }
            }
            else if (radioButton2.Checked)
            {
                dp.HeaderText = "Frais du Notaire";
                dataaa.Rows.Clear();
                foreach (DossierAffaireImmobilière cpe in Form1.lccc.ListeDossierAffaireImmobilière())
                {
                    dataaa.Rows.Add(cpe.Charge, cpe.Date_juj, cpe.Date_ouve, cpe.Cl.Nom, cpe.Cl.Prenom, cpe.Etat);
                }
            }
        }

        private void Figures4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataaa.CurrentRow != null)
            {
                dataaa.Rows.Remove(dataaa.CurrentRow);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult r = sfd.ShowDialog();
            if (r == DialogResult.OK)
            {

                FileStream f = File.Open(sfd.FileName, FileMode.OpenOrCreate);
                f.SetLength(0);
                XmlSerializer xs = new XmlSerializer(typeof(List<Dossier>));
                xs.Serialize(f, l_d);
                f.Close();
                MessageBox.Show("Les donnees sont enregistres avec succes ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier XML | *.xml";
            DialogResult r = ofd.ShowDialog();
            if (r == DialogResult.OK)
            {
                FileStream f = File.OpenRead(ofd.FileName);
                XmlSerializer xs = new XmlSerializer(typeof(List<Dossier>));
                l_d = (List<Dossier>)xs.Deserialize(f);
                f.Close();
                MessageBox.Show("Les donnes chargées avecc succes ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataaa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
