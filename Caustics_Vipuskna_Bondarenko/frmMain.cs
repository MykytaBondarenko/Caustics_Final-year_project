using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caustics_Vipuskna_Bondarenko
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.SeaGreen;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Yellow;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmBrowser frmBrowser = new frmBrowser();
            frmBrowser.StartPosition = FormStartPosition.CenterScreen;
            frmBrowser.ShowDialog();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SeaGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Yellow;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmGallery frmGallery = new frmGallery();
            frmGallery.StartPosition = FormStartPosition.CenterScreen;
            frmGallery.ShowDialog();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SeaGreen;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Yellow;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SeaGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmCaustic frmCaustic = new frmCaustic();
            frmCaustic.StartPosition = FormStartPosition.CenterScreen;
            frmCaustic.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            frmTheory frmTheory = new frmTheory();
            frmTheory.StartPosition = FormStartPosition.CenterScreen;
            frmTheory.ShowDialog();
        }

        private void label5_MouseHover_1(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SeaGreen;
        }

        private void label5_MouseLeave_1(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Yellow;
        }
    }
}
