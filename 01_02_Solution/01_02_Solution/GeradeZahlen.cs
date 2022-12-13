namespace _01_02_Solution
{
    internal class GeradeZahlen
    {
        internal void Variante1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(2 * i);
            }

        }
        internal void Variante2()
        {
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        internal void Variante3()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        internal void Variante4()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) continue;
                Console.WriteLine(i);
            }
        }
    }
}