using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace _01_11_solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void t1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t1 = new System.Windows.Forms.Timer(); // Timer anlegen
            t1.Interval = 1000; // Intervall festlegen - 1000 ms
            t1.Tick += new EventHandler(t1_Tick); // Eventhandler der beim Timerablauf aufgerufen wird
            t1.Start(); // Timer starten

            
        }
    }
}
