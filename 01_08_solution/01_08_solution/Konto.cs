using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_solution
{
    internal class Konto
    {
        private double kontostand;


        public Konto(double kontostand)
        {
            this.Kontostand = kontostand;
        }

        public double Kontostand { get => kontostand; set => kontostand = value; }
    }
}
