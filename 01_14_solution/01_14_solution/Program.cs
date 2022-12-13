namespace _01_14_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Einkaufsliste liste = new Einkaufsliste();

            String? aktion = "";
            String? ware = "";
            Console.WriteLine("Geben Sie Ihre Bestellung auf.");

            do
            {
                Console.WriteLine("Eingabe der gewünschten Ware:");
                ware = Console.ReadLine();
                if (ware.Length > 0)
                {
                    liste.MeineEinkaufsliste.Add(ware);
                }

                else
                {
                    Console.WriteLine("Eine leere Eingabe für die Ware ist nicht gestattet.");
                }
                Console.WriteLine("Weiter bestellen (1), Bezahlen (2), Bestellung abbrechen (0):");

                aktion = Console.ReadLine();

                switch (aktion)
                {
                    case "0":
                        Console.WriteLine("Abbruch der Bestellung");
                        System.Environment.Exit(0);
                        break;
                    case "1":

                        break;
                    case "2":
                        Console.WriteLine("Ihre Bestellung wird ausgeführt.");
                        break;
                    default:
                        Console.WriteLine("Auswahl der Aktion nicht erlaubt!");
                        aktion = "1";
                        break;
                }

            }
            while (aktion.Equals("1"));

            Console.WriteLine("Die Anzahl der Elemente in Ihrem Warenkorb ist {0}.", liste.MeineEinkaufsliste.Count);
            Console.WriteLine("Folgende Elemente haben Sie bestellt:");

            foreach (string s in liste.MeineEinkaufsliste)
            {
                Console.WriteLine(s);
            }
        }
    }
}