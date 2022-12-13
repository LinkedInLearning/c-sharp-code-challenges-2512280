namespace _01_01_Solution
{
    internal class Program
    {
        static int GGTeiler(int z1, int z2)
        {

            if (z2 == 0)
                return z1;
            else
                return GGTeiler(z2, z1 % z2);
        }
        static void Main(string[] args)
        {
            try
            {
                int zahl1 = 0, zahl2 = 0;


                Console.WriteLine("Bitte eine ganze Zahl eingeben: ");
                zahl1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bitte noch eine ganze Zahl eingeben: ");
                zahl2 = Convert.ToInt32(System.Console.ReadLine());

                if ((zahl1 != 0) && (zahl2 != 0))
                {
                    Console.WriteLine(GGTeiler(zahl1, zahl2) +
                        " ist der größte gemeinsame Teiler von {0} und {1}.", zahl1, zahl2);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Bitte nur ganze Zahlen ungleich 0 eingeben");
            }
        }
    }
}