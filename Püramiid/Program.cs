namespace Püramiid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Püramiid";
            Console.WriteLine("Püramiid");
            Console.WriteLine("Sisesta püramiidi suurus: ");

            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }
            Console.ReadKey();
        }
    }
}