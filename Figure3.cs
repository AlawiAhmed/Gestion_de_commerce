using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_continue
{
    public partial class Figure3 : Form
    {
        public Figure3()
        {
            InitializeComponent();
        }

        private void Figure3_Load(object sender, EventArgs e)
        {
            string[] t = { "Clôturé", "Jugé", "Clôturé", "Attente de jugement", " En traitement " };
            comboBox1.Items.Add(t);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lblHoraire.Text = "Frais Notaire";
            }
            else
            {
                lblHoraire.Text = "Horaire Avocat";
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtpre.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            txtnu.Text = "";
            txtnomAv.Text = "";
            txtCharge.Text = "";
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtporcentageAvocat.Text = "";
            txthoraireA.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnu.Text != "")
                {
                    Avocat v = new Avocat(32, "gx", "hgfx");
                    Client c = new Client(txtnom.Text, txtpre.Text, v);
                    if (radioButton2.Checked)
                    {
                        DossierAffaireImmobilière cc = new DossierAffaireImmobilière();


                        cc.Numero_dossier = int.Parse(txtnu.Text);
                        cc.Date_ouve = (dateTimePicker1.Value);
                        cc.Date_juj = (dateTimePicker2.Value);



                        Form1.lccc.Ajouter(cc);
                        MessageBox.Show("Compte ajouter avec succser");
                    }
                    else if (radioButton1.Checked)
                    {
                        DossierAffaireCriminelle ce = new DossierAffaireCriminelle();
                        ce.Numero_dossier = int.Parse(txtnu.Text);
                        ce.Date_ouve = (dateTimePicker1.Value);
                        ce.Date_juj = (dateTimePicker2.Value);
                        Form1.lccc.Ajouter(ce);
                        MessageBox.Show("Compte ajouter avec succser");
                    }
                }
                else { MessageBox.Show("vueiller remplire tous les champs"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
    }

