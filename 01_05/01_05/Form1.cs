using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailtestRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Genauere Validierung einer E-Mail-Adresse mit regulärem Ausdruck
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail2()
        {
            /*
             * ^                :   Beginn mit dem nachfolgenden Ausdruck
             * [a-zA-Z]         :   Nur Buchstaben als erstes Zeichen
             * ([\w\-\.]*)      :   Alle Buchstaben, Ziffern und der Unterstrich sowie Minuszeichen und Punkt als Sonderzeichen - gar nicht oder beliebig oft
             * @                :   Das Zeichen @
             * [a-zA-Z0-9]      :   Nur Buchstaben oder Zahlen als erstes Zeichen nach dem @
             * ([\w\-\.]*)      :   Alle Buchstaben, Ziffern und der Unterstrich sowie Minuszeichen und Punkt als Sonderzeichen - gar nicht oder beliebig oft
             * ((\.(\w){2,})+)  :   Punkt zum Abtrennen des Top-Level, gefolgt von allen Buchstaben, Ziffern und der Unterstrich  - mindestens 1x
             * $                :   Ende mit dem dem beschriebenen Ausdruck
             */

             /*
             *
             * Your Code goes here
             *
             */
                         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ValidateEmail2();
        }

    
    }
}
