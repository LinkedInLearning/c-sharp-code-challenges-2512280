namespace _01_08_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konto meinKonto = new Konto(0); ;
            EinAus io = new EinAus();
            String? aktion = "";




            io.Ausgabe(meinKonto);

            do
            {
                Console.WriteLine("Einzahlen (1), Auszahlen (2), Beenden (0):");
                aktion = Console.ReadLine();

                switch (aktion)
                {
                    case "0":
                        break;
                    case "1":
                        meinKonto.Kontostand += io.Eingabe();
                        break;
                    case "2":
                        meinKonto.Kontostand -= io.Eingabe();
                        break;
                    default:
                        Console.WriteLine("Auswahl der Atkion nicht erlaubt!");
                        break;
                }

                io.Ausgabe(meinKonto);
            }
            while (!aktion.Equals("0"));
        }
    }
}