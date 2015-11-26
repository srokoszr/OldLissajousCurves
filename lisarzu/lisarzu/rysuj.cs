using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lisarzu
{
    public partial class rysuj : Form
    {
        public rysuj()
        {
            InitializeComponent();
        }

        private void rysuj_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pictureBox1);

        }

            double wspolczynnik = 0;
            Bitmap mapa = new Bitmap(666, 666);

            Brush brush = Brushes.Black;
            Pen mazak = Pens.Black;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            pictureBox1.Image = mapa;
            double t = 0;
            PointF stary_punkt = new System.Drawing.PointF(float.Parse((Form1.a * Math.Sin(Form1.a_ * t + Form1.ile * Math.PI + wspolczynnik) + 333).ToString()), float.Parse((Form1.b * Math.Sin(Form1.b_ * t) + 333).ToString()));
            while(true)
            {
                PointF nowy_punkt = new System.Drawing.PointF(float.Parse((Form1.a * Math.Sin(Form1.a_ * t + Form1.ile * Math.PI + wspolczynnik) + 333).ToString()), float.Parse((Form1.b * Math.Sin(Form1.b_ * t) + 333).ToString()));
                g.DrawLine(mazak, stary_punkt, nowy_punkt);
                stary_punkt = nowy_punkt;
                System.Threading.Thread.Sleep(Form1.spowolnienie);
                if (Form1.zwiekszaj)
                {
                    wspolczynnik += 0.1;
                }
                t += 0.001;
                double resztaa = ((Form1.a_ * t) / 2) / Math.PI;
                double resztab = ((Form1.b_ * t )/ 2) / Math.PI;
                if ((resztaa - Math.Floor(resztaa)) < 0.0001 && (resztab - Math.Floor(resztab)) < 0.0001)
                //if((Form1.a_ * t )==Math.PI&&(Form1.b_ * t )==Math.PI)
                {
                    break;
                }
            }
            g.Save();
        }
    }
}
