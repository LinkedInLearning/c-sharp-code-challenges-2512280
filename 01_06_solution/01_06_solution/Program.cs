using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_06_solution;

Taschenrechner t = new Taschenrechner();
String? op = "";
try
{
    int zahl1 = 0, zahl2 = 0;



    Console.WriteLine("Bitte eine ganze Zahl eingeben: ");
    zahl1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bitte noch eine ganze Zahl eingeben: ");
    zahl2 = Convert.ToInt32(System.Console.ReadLine());
    Console.WriteLine("Geben Sie die Rechenoperation ein (+,*,/,-): ");
    op = System.Console.ReadLine();
    switch (op)
    {
        case "+":
            t.Addition(zahl1, zahl2); Console.WriteLine(
            "Die Addition von {0} und {1} ergibt {2}.", zahl1, zahl2, t.Ergebnis); break;
        case "-":
            t.Subtraktion(zahl1, zahl2); Console.WriteLine(
            "Die Subtraktion von {0} und {1} ergibt {2}.", zahl1, zahl2, t.Ergebnis); break;
        case "*":
            t.Multiplikation(zahl1, zahl2); Console.WriteLine(
            "Die Multiplikation von {0} und {1} ergibt {2}.", zahl1, zahl2, t.Ergebnis); break;
        case "/":
            t.Division(zahl1, zahl2); Console.WriteLine(
            "Die Division von {0} und {1} ergibt {2}.", zahl1, zahl2, t.Ergebnis); break;
        default: Console.WriteLine("Keine gültige Operation"); break;
    }

}
catch (Exception)
{
    Console.WriteLine("Bitte nur ganze Zahlen ungleich 0 eingeben");
}
