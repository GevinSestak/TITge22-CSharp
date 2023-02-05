namespace Kolmnurk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kolmnurk konsoolis";
            Console.WriteLine("Kolmnurk tähtedest");
            Console.WriteLine("Sisesta ridade arv:");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++) {
                Console.Write("\n");
                for (int b = 0; b <= i; b++) {
                    Console.Write("*");
                }
            }
            Console.ReadKey();
        }
    }
}