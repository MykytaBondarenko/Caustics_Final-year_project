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
    public partial class frmTitul : Form
    {
        public frmTitul()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
            frmMain.ShowDialog();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SeaGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
