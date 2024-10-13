
namespace Caustics_Vipuskna_Bondarenko
{
    partial class frmBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Вступ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Корабельні хвилі");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Веселка");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("У воді");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Каустики в природі", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Коло");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Парабола");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Цисоїда Діокла");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Кардіоїда");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Криві та їх каустики", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Архітектура");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Зображення через скло");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Комп\'ютерна графіка");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Виявлення екзопланет");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Гравітаційна лінза");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Практичне застосування", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.labela = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.BackColor = System.Drawing.Color.Transparent;
            this.labela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labela.ForeColor = System.Drawing.Color.Gold;
            this.labela.Location = new System.Drawing.Point(107, 616);
            this.labela.Name = "labela";
            this.labela.Padding = new System.Windows.Forms.Padding(5);
            this.labela.Size = new System.Drawing.Size(128, 48);
            this.labela.TabIndex = 1;
            this.labela.Text = "Назад";
            this.labela.Click += new System.EventHandler(this.labela_Click);
            this.labela.MouseLeave += new System.EventHandler(this.labela_MouseLeave);
            this.labela.MouseHover += new System.EventHandler(this.labela_MouseHover);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(366, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(722, 679);
            this.webBrowser1.TabIndex = 12;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Вступ";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Корабельні хвилі";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Веселка";
            treeNode4.Name = "Node7";
            treeNode4.Text = "У воді";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Каустики в природі";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Коло";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Парабола";
            treeNode8.Name = "Node11";
            treeNode8.Text = "Цисоїда Діокла";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Кардіоїда";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Криві та їх каустики";
            treeNode11.Name = "Node15";
            treeNode11.Text = "Архітектура";
            treeNode12.Name = "Node16";
            treeNode12.Text = "Зображення через скло";
            treeNode13.Name = "Node17";
            treeNode13.Text = "Комп\'ютерна графіка";
            treeNode14.Name = "Node18";
            treeNode14.Text = "Виявлення екзопланет";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Гравітаційна лінза";
            treeNode16.Name = "Node14";
            treeNode16.Text = "Практичне застосування";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode10,
            treeNode16});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(330, 533);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sun icon.png");
            this.imageList1.Images.SetKeyName(1, "moon icon.png");
            // 
            // frmBrowser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labela);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBrowser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}