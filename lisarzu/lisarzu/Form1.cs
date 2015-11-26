using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lisarzu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public const double pi = 3.14159;
        public static double ile = 0.5;
        public static double a = 100;
        public static double b = 100;
        public static double a_ = 1;
        public static double b_ = 1;
        public static int spowolnienie = 0;
        public static bool zwiekszaj = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if ( richTextBox1.Text!= "")
                a = double.Parse(richTextBox1.Text);
            if (richTextBox2.Text != "")
                b = double.Parse(richTextBox2.Text);
            if (richTextBox3.Text != "")
                a_ = double.Parse(richTextBox3.Text);
            if (richTextBox4.Text != "")
                b_ = double.Parse(richTextBox4.Text);
            if (richTextBox5.Text != "")
                ile = double.Parse(richTextBox5.Text);
            if (richTextBox6.Text != "")
                spowolnienie = int.Parse(richTextBox6.Text);
            zwiekszaj = checkBox1.Checked;
            rysuj rysuj = new rysuj();
            rysuj.ShowDialog();
        }
    }
}
