namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tuple";
            Console.WriteLine("Tuple\n\n");

            var humans = System.Tuple.Create(1, "Jaan", "Tallinn");
            Console.WriteLine(humans);
            Console.WriteLine("--------------------");
            Console.WriteLine(humans.Item1);
            Console.WriteLine(humans.Item2);
            Console.WriteLine(humans.Item3);
            Console.WriteLine("--------------------");

            var numbers = System.Tuple.Create("One", 2, 3, 4, 5, "Six", 7, 8);
            Console.WriteLine(numbers);
            Console.WriteLine("--------------------");
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);
            Console.WriteLine("--------------------");


            var bigNumbers = System.Tuple.Create(1, 2, 3, 4, 5, 6, 7, System.Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(bigNumbers.Item1);
            Console.WriteLine(bigNumbers.Item7);
            Console.WriteLine(bigNumbers.Rest.Item1);
            Console.WriteLine(bigNumbers.Rest.Item1.Item1);
            Console.WriteLine(bigNumbers.Rest.Item1.Item2);

            DisplayTuple(humans);
            var inimene = GetHuman();
            Console.WriteLine(inimene);

            Console.ReadKey();
        }
        // Tuple väärtuse saamine läbi meetodi parameetrite
        static void DisplayTuple(Tuple<int, string, string> humans)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"ID = {humans.Item1}");
            Console.WriteLine($"Eesnimi = {humans.Item2}");
            Console.WriteLine($"Perekonnanimi = {humans.Item3}");
        }
        // Tuple kui return tüüp
        static Tuple<int, string, string > GetHuman()
        {
            Console.WriteLine("----------------------");
            return System.Tuple.Create(1, "Bill", "Gates");
        }
    }
}