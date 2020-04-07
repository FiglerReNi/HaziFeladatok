using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasodfokuHazi0610
{
    public partial class Form1 : Form
    {
        double a, b, c, d;                      //másodfokú egyenlet megoldása
        double x1, x2;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = b * b - 4 * a * c;
            if (d < 0)
            {
                textBox4.Text = "Nincs valós megoldás.";
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                
                textBox4.Text = "X1 = " + Math.Round(x1, 2); ;
                textBox4.AppendText("\r\nX2 = " + Math.Round(x2, 2));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);

                if (a == 0)
                {
                    MessageBox.Show("Így nem másodfokú az egyenlet!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
  

