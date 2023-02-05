namespace ForLoop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Näita korrutustabelit";
            Console.WriteLine("Näita korrutustabelit ja sisesta korrutis!");

            int j, n;
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n");
            n = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 10; j++) {
                Console.Write("{0} x {1} = {2}\n", n, j, n * j);
            }
            Console.ReadKey();
        }
    }
}