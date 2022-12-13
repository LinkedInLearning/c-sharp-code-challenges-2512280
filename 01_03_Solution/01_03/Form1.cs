namespace _01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Einfache Validierung einer E-Mail-Adresse
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail1()
        {
            /*
             * Abfangen der Länge.
             * Eine E-Mail benötigt das @-Zeichen und mindestens ein Zeichen davor und danach. 
             * Deshalb Länge 3 als Mindestlänge
             * Damit wird auch gleich einer Ausnahme in der zweiten Prüfung vorgebeugt, wenn das 1. Zeichen nicht vorhanden ist
             */
            if (textBox1.Text.Length < 3)
            {
                textBox2.Text = "Eine E-Mail muss mindestens 3 Zeichen lang sein";
                return false;
            }
            /*
             * Kontrolle erstes Zeichen der E-Mail nach Zahl, Sonderzeichen und @ 
             */
            if (Char.IsNumber(textBox1.Text[0]) ||
                Char.IsSymbol(textBox1.Text[0]) ||
                textBox1.Text[0].Equals("@"))
            {
                textBox2.Text = "Eine E-Mail kann nicht mit einer Zahl, einem Sonderzeichen oder dem @-Zeichen beginnen.";
                return false;
            }
            /*
             * Vorkommen von @ ab dem 2. Zeichen und vor dem letzten Zeichen.
             * Mehrfaches Vorkommen von @ wird ebenso unterbunden
             */

            if (
                !(textBox1.Text.IndexOf("@") > 0 && textBox1.Text.IndexOf("@") == textBox1.Text.LastIndexOf("@")) ||
                (textBox1.Text.LastIndexOf("@") == textBox1.Text.Length - 1))
            {
                textBox2.Text = "Eine E-Mail muss das @-Zeichen enthalten und es muss vor dem letzten Zeichen stehen.";
                return false;
            }



            textBox2.Text = "Die E-Mail erfüllt wichtige, einfache Regeln und könnte valide sein!";
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateEmail1();
        }

    }
}