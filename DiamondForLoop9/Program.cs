using System.Globalization;

namespace DiamondForLoop9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teemant");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;
            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row-i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            for (int i = row-1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}