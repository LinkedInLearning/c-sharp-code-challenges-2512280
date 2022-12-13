using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            else
            {
                if (value > 2)
                {
                    for (int i = 2; i <= (value / 2) + 1; i++)
                        if (value % i == 0)
                            return false;
                }
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                if (IsPrime(i))
                {
                    label2.Text = "Primzahl";
                }
                else
                {
                    label2.Text = "Keine Primzahl";
                }
            }
            catch (Exception)
            {
                label2.Text = "Keine Primzahl";
            }

        }
    }
}
