namespace _01_09_solution_ohne_top_level_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erstellen eines Kontos");
			Konto kt = new Konto(12345.56,5555,new Person("Dent","Arthur",42));
            Console.WriteLine(kt.Kontonr);
        }
    }
}