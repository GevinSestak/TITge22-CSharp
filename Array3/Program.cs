using System.Xml.Schema;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine("\n");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremaks");
            //Sorteerib numbrid ära
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sorteerib numbrid suuremast väiksemani");
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Console.ReadKey();
        }
    }
}