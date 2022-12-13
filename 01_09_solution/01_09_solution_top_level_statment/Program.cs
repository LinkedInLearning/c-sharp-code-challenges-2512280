// See https://aka.ms/new-console-template for more information

using _01_09_solution_top_level_statement;

Console.WriteLine("Erstellen eines Kontos");
Konto kt = new Konto(12345.56, 5555, new Person("Dent", "Arthur", 42));
Console.WriteLine(kt.Kontonr);
