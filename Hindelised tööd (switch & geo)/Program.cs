using System.Drawing;
using System.Security.Principal;

namespace HindelineTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Square();
                    break;
                case "2":
                    Diamond();
                    break;
                case "3":
                    Rectangle();
                    break;
                case "4":
                    Triangle();
                    break;
                default:
                    Console.WriteLine("Kujundit ei valitud");
                    break;
            }
        }
        private static void Square()
        {
            Console.WriteLine("Ruut");
            Console.WriteLine("Sisesta ruudu külje pikkus: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pindala:" + size * size);
            Console.WriteLine("Ümbermõõt:" + 4 * size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static void Rectangle()
        {
            Console.WriteLine("Sisestage ristküliku laius: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisestage ristküliku kõrgus: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Ümbermõõt: " + 2 * (width + height));
            Console.WriteLine("Pindala: " + width * height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static void Diamond()
        {
            Console.WriteLine("Teemant");
            Console.WriteLine("Sisesta läbimõõt: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;
            Console.WriteLine("Pindala: " + (Math.PI * (row / 2) * (row / 2)) / 2);
            Console.WriteLine("Ümbermõõt: " + Math.PI * row);
            for (int i = 0; i <= row; i++)
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
            for (int i = row - 1; i >= 1; i--)
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
        private static void Triangle()
        {
            Console.WriteLine("Sisesta kolmnurga alus:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kõrgus:");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double areaOfTriangle = (triangleBase * triangleHeight) / 2;
            Console.WriteLine("Pindala: " + areaOfTriangle);
            for (int i = 0; i <= triangleHeight; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}