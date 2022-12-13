using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_solution
{
    internal class EinAus
    {
        public double Eingabe()
        {
            double betrag = 0;
            Console.Write("Betrag: ");
            try
            {
                betrag = Convert.ToDouble(Console.ReadLine());
                if (betrag <= 0)
                {
                    Console.WriteLine("Bitte nur positive Zahlen eingeben.");
                    return 0;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Bitte nur positive Zahlen eingeben.");
                return 0;
            }
            return betrag;
        }
        public void Ausgabe(Konto meinKonto)
        {
            Console.WriteLine("Der aktuelle Kontostand ist {0} EUR.", meinKonto.Kontostand);
        }
    }
}
