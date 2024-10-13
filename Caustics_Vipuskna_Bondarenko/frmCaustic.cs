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
    public partial class frmCaustic : Form
    {
        public frmCaustic()
        {
            InitializeComponent();
        }

        Graphics gr;
        int i1, i2, j1, j2, x1, x2, y1, y2;
        double t, p, y, x, x0, y0, k, b, yd, pi, x00;

        void system_koordinat(double x1, double x2, double y1, double y2) // система координат
        {
            Pen pen_setka = new Pen(Brushes.LightBlue, 1);
            pen_setka.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (int p = (int)x1; p <= (int)x2; p++)
            {
                gr.DrawLine(pen_setka, xtoi(p), ytoj(y2), xtoi(p), ytoj(y1));
            }

            for (int p = (int)y1; p <= (int)y2; p++)
            {
                gr.DrawLine(pen_setka, xtoi(x1), ytoj(p), xtoi(x2), ytoj(p));
            }

            Pen pen_os = new Pen(Brushes.Blue, 1);
            pen_os.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen_os.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;

            gr.DrawLine(pen_os, xtoi(x1), ytoj(0), xtoi(x2), ytoj(0));
            gr.DrawLine(pen_os, xtoi(0), ytoj(y1), xtoi(0), ytoj(y2));

            Font MyFont = new Font("arial", 8, FontStyle.Regular);
            for (int p = 1; p <= x2; p++) gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
            for (int p = -1; p >= x1; p--) gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(p - 0.2), ytoj(-0.05)));
            for (int p = 0; p <= y2; p++) gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.5), ytoj(p + 0.1)));
            for (int p = -1; p >= y1; p--) gr.DrawString(Convert.ToString(p), MyFont, Brushes.Blue, new Point(xtoi(-0.6), ytoj(p + 0.1)));
        }

        int xtoi(double x)
        {
            int ii;
            ii = i1 + (int)Math.Truncate((x - x1) * (i2 - i1) / (x2 - x1));
            return ii;
        }

        int ytoj(double y)
        {
            int jj;
            jj = j2 + (int)Math.Truncate((y - y1) * (j1 - j2) / (y2 - y1));
            return jj;
        }

        double f1x(double xt)
        {
            double p = Convert.ToDouble(txtp.Text);
            double ff = xt;
            return ff;
        }

        double f1y(double xt)
        {
            double p = Convert.ToDouble(txtp.Text);
            double ff = Math.Pow(xt, 2) / (2 * p);
            return ff;
        }

        double f2x(double xt)
        {
            double p = Convert.ToDouble(txtp.Text);
            double ff = xt;
            return ff;
        }

        double f2y(double xt, double k, double b)
        {
            double p = Convert.ToDouble(txtp.Text);
            double ff = k * xt + b;
            return ff;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
            frmMain.ShowDialog();
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.ForeColor = Color.SeaGreen;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Gold;
        }

        private void button1_Click(object sender, EventArgs e) // побудова системи координат
        {
            if (txtx1.Text != "" && txtx2.Text != "" && txty1.Text != "" && txty2.Text != "")
            {
                gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                label5.Text = "Введіть розміри координатної сітки";

                i1 = 0;
                j1 = 0;
                i2 = pictureBox1.Width - 1;
                j2 = pictureBox1.Height - 1;
                x1 = Convert.ToInt32(txtx1.Text);
                x2 = Convert.ToInt32(txtx2.Text);
                y1 = Convert.ToInt32(txty1.Text);
                y2 = Convert.ToInt32(txty2.Text);
                system_koordinat(x1, x2, y1, y2);
            }
            else label5.Text = "Введіть межі системи координат";
        }

        private void button4_Click(object sender, EventArgs e) // вгору
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            y1--; y2--;
            system_koordinat(x1, x2, y1, y2);
        } 

        private void button5_Click(object sender, EventArgs e) // вліво
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x1++; x2++;
            system_koordinat(x1, x2, y1, y2);
        }

        private void button6_Click(object sender, EventArgs e) // вправо
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x1--; x2--;
            system_koordinat(x1, x2, y1, y2);
        }

        private void button7_Click(object sender, EventArgs e) // вниз
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            y1++; y2++;
            system_koordinat(x1, x2, y1, y2);
        }

        private void button2_Click(object sender, EventArgs e) // +масштаб
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x1++; x2--;
            y1++; y2--;
            system_koordinat(x1, x2, y1, y2);
        }

        private void button3_Click(object sender, EventArgs e) // -масштаб
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            x1--; x2++;
            y1--; y2++;
            system_koordinat(x1, x2, y1, y2);
        }

        private void button8_Click(object sender, EventArgs e) // побудова параболи
        {
            gr.Clear(Color.White);
            i1 = 0;
            j1 = 0;
            i2 = pictureBox1.Width - 1;
            j2 = pictureBox1.Height - 1;
            system_koordinat(x1, x2, y1, y2);
            pi = Convert.ToDouble(txtpi.Text);
            p = Convert.ToDouble(txtp.Text);

            t = -pi * Math.PI;
            while (t < pi * Math.PI)
            {
                gr.FillEllipse(Brushes.Red, xtoi(f1x(t)), ytoj(f1y(t)), 4, 4);
                t += 0.01;
            }
        }

        private void button9_Click(object sender, EventArgs e) // побудова каустики
        {
            i1 = 0;
            j1 = 0;
            i2 = pictureBox1.Width - 1;
            j2 = pictureBox1.Height - 1;

            pi = Convert.ToDouble(txtpi.Text);
            t = -pi * Math.PI;
            y = f1y(-pi * Math.PI); // початковий у буде мати у параболи в точці початку проміжку
            p = Convert.ToDouble(txtp.Text);
            while (t < pi * Math.PI)
            {
                if (y > f1y(t)) // будуємо пряму лінію вниз, поки у не дійде до параболи
                {
                    gr.FillEllipse(Brushes.Orange, xtoi(t), ytoj(y), 1.5f, 1.5f);
                    y -= 0.01;
                }
                else
                {
                    x0 = t;
                    if (x0 > 0) x00 = -x0; // детально про змінні х0 та х00 в розділі "Посібник користувача" документації
                    else x00 = x0;
                    y0 = f1y(t);
                    yd = (-(Math.Pow(x00, 2)) + 4 * p * x00) / (4 * Math.Pow(p, 2)); // визначаємо k дотичної прямої, це буде y'(x0) (похідна), детальніше в розділі "Посібник користувача" в документації
                    k = (1 - Math.Pow(yd, 2)) / (-2 * yd); // визначаємо k відбитого променя, детальніше в розділі "Посібник користувача" документаціїї
                    if (x0 > 0) k *= -1;
                    b = y0 - k * x0; // виводимо b з лінійного рівняння
                    x = t;
                    while (x < (pi - 0.5) * Math.PI && x > (0.5 - pi) * Math.PI && f2y(x, k, b) < f1y(pi * Math.PI))
                    {
                        y0 = f1y(t);
                        gr.FillEllipse(Brushes.Orange, xtoi(f2x(x)), ytoj(f2y(x, k, b)), 1.5f, 1.5f);
                        if (x0 < 0) x += 0.01;
                        else x -= 0.01;
                        if (f2y(x, k, b) < f1y(x)) x = pi * Math.PI; // якщо промінь досягає параболи, цикл одразу зупиняється
                    }
                    y = f1y(-pi * Math.PI);
                    t += 0.15 * pi; // потрібно, щоб при великій параболі промені не були над-то близько один до одного
                }
            }
        }

        private void button10_Click(object sender, EventArgs e) // очистити полотно
        {
            gr.Clear(Color.White);
            system_koordinat(x1, x2, y1, y2);
        }
    }
}
