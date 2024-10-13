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

namespace Caustics_Vipuskna_Bondarenko
{
    public partial class frmTheory : Form
    {
        public frmTheory()
        {
            InitializeComponent();
        }

        string path;
        int n;

        private void labela_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
            frmMain.ShowDialog();
        }

        private void labela_MouseHover(object sender, EventArgs e)
        {
            labela.ForeColor = Color.SeaGreen;
        }

        private void labela_MouseLeave(object sender, EventArgs e)
        {
            labela.ForeColor = Color.Gold;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.SeaGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SeaGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gold;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SeaGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gold;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SeaGreen;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gold;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SeaGreen;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Gold;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "desmos.jpg");
            n = 1;
            linkLabel1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "вікіпедія.jpg");
            n = 2;
            linkLabel1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "british library.jpg");
            n = 3;
            linkLabel1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "french library.jpg");
            n = 4;
            linkLabel1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "galileo unbound.jpg");
            n = 5;
            linkLabel1.Visible = true;
        }

        private void frmTheory_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            path = Application.StartupPath + "\\online\\";
            pictureBox1.Load(path + "idle.jpg");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (n)
            {
                case 1: System.Diagnostics.Process.Start("https://www.desmos.com/calculator?lang=uk");
                    break;
                case 2: System.Diagnostics.Process.Start("https://uk.wikipedia.org");
                    break;
                case 3: System.Diagnostics.Process.Start("https://www.bl.uk/");
                    break;
                case 4: System.Diagnostics.Process.Start("https://gallica.bnf.fr/accueil/en/content/accueil-en?mode=desktop");
                    break;
                case 5: System.Diagnostics.Process.Start("https://galileo-unbound.blog");
                    break;
            }
        }
    }
}
