using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06_solution
{
    /// <summary>
    /// Partielle Klasse mit den Rechenoperationen
    /// </summary>
    public partial class Taschenrechner
    {
        public void Addition(int zahl1, int zahl2)
        {
            Ergebnis = zahl1 + zahl2;

            
        }
        public void Subtraktion(int zahl1, int zahl2)
        {
            Ergebnis = zahl1 - zahl2;


        }
        public void Division(int zahl1, int zahl2)
        {
            Ergebnis = zahl1 / zahl2;


        }
        public void Multiplikation(int zahl1, int zahl2)
        {
            Ergebnis = zahl1 * zahl2;


        }
    }
}
