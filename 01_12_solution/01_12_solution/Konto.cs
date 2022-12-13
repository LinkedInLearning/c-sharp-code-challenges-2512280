using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_solution
{
    internal class Konto
    {
        double kontostand;
        int kontonr;
        Person kunde;

        public Konto(double kontostand, int kontonr, Person kunde)
        {
            this.kontostand = kontostand;
            this.kontonr = kontonr;
            this.kunde = kunde;
        }

        public double Kontostand { get; set; }
        public int Kontonr { get; set; }
        internal Person Kunde { get; set; }

    }
}
