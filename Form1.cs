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
    public partial class Form1 : Form
    {


        public static ListeDossier lccc = new ListeDossier();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ex = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Figure3")
                {
                    ex = true;
                    f.Focus();
                    break;
                }
            }
            if (ex == false)
            {
                Figure3 ac = new Figure3();
                ac.MdiParent = this;
                ac.Show();
            }
        }

        private void listeDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ex = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Figures4")
                {
                    ex = true;
                    f.Focus();
                    break;
                }
            }
            if (ex == false)
            {
                Figures4 ac = new Figures4();
                ac.MdiParent = this;
                ac.Show();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
