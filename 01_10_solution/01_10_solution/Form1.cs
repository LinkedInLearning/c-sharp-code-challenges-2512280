using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_10_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.AliceBlue);
            Pen stift = new Pen(Color.Red);
            for (int i = 0; i < 400; i++)
            {
                g.DrawEllipse(stift, 5, 5, i, i);
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
                if (i < 399) g.Clear(Color.AliceBlue);
            }
        }
    }
}
