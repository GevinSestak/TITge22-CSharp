namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array 1";
            int[] numbers = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                // Massiiv taha ka kui soovid mingit väärtust. Kui soovid kõiki välja tuua siis kasutad I väärtust vms, samuti kui soovid teatud numbrit siis asendad selle mingi numbriga.
                // Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n--------------------------\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                // Liitsime 10 ühikut juurde antud arrayle.
                numbers[i] = numbers[i] + 10;
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}