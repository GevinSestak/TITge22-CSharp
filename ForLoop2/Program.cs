namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tärnide arv");

            int number = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Prindin {0} tärne", number);

            for (int i = 0; i < number; i++) {
                Console.WriteLine("*");
            }
        }
    }
}