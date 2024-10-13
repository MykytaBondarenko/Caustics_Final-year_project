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
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
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

        private void labela_MouseLeave(object sender, EventArgs e)
        {
            labela.ForeColor = Color.Gold;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            int sqq = treeView1.SelectedNode.Index;

            if (st1 == "Вступ") webBrowser1.Navigate(path + "\\texts\\Вступ.htm");
            if (st1 == "Каустики в природі") webBrowser1.Navigate(path + "\\texts\\Каустики в природі.htm");
            if (st1 == "Корабельні хвилі") webBrowser1.Navigate(path + "\\texts\\Корабельні хвилі.htm");
            if (st1 == "Веселка") webBrowser1.Navigate(path + "\\texts\\Веселка.htm");
            if (st1 == "У воді") webBrowser1.Navigate(path + "\\texts\\У воді.htm");
            if (st1 == "Криві та їх каустики") webBrowser1.Navigate(path + "\\texts\\Каустики та їх криві.htm");
            if (st1 == "Коло") webBrowser1.Navigate(path + "\\texts\\Коло.htm");
            if (st1 == "Парабола") webBrowser1.Navigate(path + "\\texts\\Парабола.htm");
            if (st1 == "Цисоїда Діокла") webBrowser1.Navigate(path + "\\texts\\Цисоїда Діокла.htm");
            if (st1 == "Кардіоїда") webBrowser1.Navigate(path + "\\texts\\Кардіоїда.htm");
            if (st1 == "Практичне застосування") webBrowser1.Navigate(path + "\\texts\\Практичне застосування явища.htm");
            if (st1 == "Архітектура") webBrowser1.Navigate(path + "\\texts\\Архітектура.htm");
            if (st1 == "Зображення через скло") webBrowser1.Navigate(path + "\\texts\\Зображення через скло.htm");
            if (st1 == "Комп'ютерна графіка") webBrowser1.Navigate(path + "\\texts\\Комп'ютерна графіка.htm");
            if (st1 == "Виявлення екзопланет") webBrowser1.Navigate(path + "\\texts\\Виявлення екзопланет.htm");
            if (st1 == "Гравітаційна лінза") webBrowser1.Navigate(path + "\\texts\\Гравітаційна лінза.htm");
        }
    }
}
