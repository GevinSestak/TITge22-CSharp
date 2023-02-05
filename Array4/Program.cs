using System;
using System.Globalization;

namespace Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array loomadega";
            string[] animals = { "Kass", "Krokodill", "Rebane", "Ahv", "Karu", "Elevant", "Kits" };

            // Tähestiku järgi paneb loomad
            //Array.Sort(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sorteerib kolme esimest elementi animals muutuja seast. Ülejäänud kuvab nii nagu olen need massiivid esitanud");
            Array.Sort(animals, 0, 3);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            // Muutuja numbers on VÕTI ja selle taga olev numberNames on väärtus. Array.Sorti-is viiakse need omavahel kokku 
            int[] numbrid = { 2, 1, 4, 3 };
            string[] numberNames = { "two", "one", "four", "three" };
            
            Array.Sort(numbrid, numberNames);
            for (int i = 0; i < numbrid.Length; i++)
            {
                Console.WriteLine(numbrid[i]);
            }
            for (int i = 0; i < numberNames.Length; i++)
            {
                Console.WriteLine(numberNames[i]);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Loomade nimistu tagurpidi. Array.Reverse funktsioon");
            Array.Reverse(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.ReadKey();
        }
    }
}