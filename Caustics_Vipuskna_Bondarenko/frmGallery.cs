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
    public partial class frmGallery : Form
    {
        public frmGallery()
        {
            InitializeComponent();
        }

        string[] sText, sDesc;
        string path;
        int Count, n, nMain, p1, p2, p3, p4, p5;

        void LoadPict()
        {
            string st;
            st = n.ToString() + ".jpg";
            pctMain.Load(path + st);
            label1.Text = sText[n - 1];
            txt1.Text = sDesc[n - 1];

            if (n <= Count - 4)
            {
                pct1.Load(path + n.ToString() + ".jpg");
                p1 = n;
                pct2.Load(path + (n + 1).ToString() + ".jpg");
                p2 = n + 1;
                pct3.Load(path + (n + 2).ToString() + ".jpg");
                p3 = n + 2;
                pct4.Load(path + (n + 3).ToString() + ".jpg");
                p4 = n + 3;
                pct5.Load(path + (n + 4).ToString() + ".jpg");
                p5 = n + 4;
            }
            else
            {
                int temp = Count - 4;
                pct1.Load(path + temp.ToString() + ".jpg");
                p1 = temp;
                pct2.Load(path + (temp + 1).ToString() + ".jpg");
                p2 = temp + 1;
                pct3.Load(path + (temp + 2).ToString() + ".jpg");
                p3 = temp + 2;
                pct4.Load(path + (temp + 3).ToString() + ".jpg");
                p4 = temp + 3;
                pct5.Load(path + (temp + 4).ToString() + ".jpg");
                p5 = temp + 4;
            }
            if (n == Count)
            {
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
            }

            if (n == 1)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }



        private void pct1_Click(object sender, EventArgs e)
        {
            n = p1;
            LoadPict();
        }

        private void pct2_Click(object sender, EventArgs e)
        {
            n = p2;
            LoadPict();
        }

        private void pct3_Click(object sender, EventArgs e)
        {
            n = p3;
            LoadPict();
        }

        private void pct4_Click(object sender, EventArgs e)
        {
            n = p4;
            LoadPict();
        }

        private void pct5_Click(object sender, EventArgs e)
        {
            n = p5;
            LoadPict();
        }


        private void frmGallery_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + "\\Photo\\";
            pctMain.Load(path + "1.jpg");
            sText = File.ReadAllLines("Photo\\Photo.txt");
            sDesc = File.ReadAllLines("Photo\\Description.txt");
            Count = sText.Count();
            nMain = 1;
            n = 1;
            pictureBox1.Visible = false;
            LoadPict();
        }

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            n++;
            nMain++;
            LoadPict();
        }

        private void labela_MouseLeave(object sender, EventArgs e)
        {
            labela.ForeColor = Color.Gold;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            n--;
            nMain--;
            LoadPict();
        }
    }
}
