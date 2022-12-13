using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06_solution
{
    /// <summary>
/// Partielle Klasse mit dem Ergebnis
/// </summary>
    public partial class Taschenrechner
    {
        private int ergebnis;

        public int Ergebnis { get => ergebnis; set => ergebnis = value; }
    }
}
