using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_09_solution_top_level_statement;

namespace _01_09_solution_top_level_statement
{
    internal class Konto
    {
        public Konto(double kontostand, int kontonr, Person kunde)
        {
            this.Kontostand = kontostand;
            this.Kontonr = kontonr;
            this.Kunde = kunde;
        }

        public double Kontostand { get; set; }
        public int Kontonr { get; set; }
        internal Person Kunde { get; set; }
    }
}
