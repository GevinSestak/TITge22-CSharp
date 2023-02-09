using System.Data;

namespace Tulemus1
{
    internal class Program
    {
        float num, precent;
        static void Main(string[] args) {
            Console.Title = "Tulemus";
            Program a = new();
            a.Accept();
            Console.ReadKey();
        }
        public void Accept() {
            Console.WriteLine("\nSisesta hinne:\t");
            num = float.Parse(Console.ReadLine());
            Print();
        }
        public void Print() {
            precent = (float)num / 850 * 100;

            if (precent < 35) {
                Console.WriteLine("Kukkusid läbi! Hindeks: " + precent);
            }
            else if (precent > 35 && precent < 50) {
                Console.WriteLine("Hindeks E. Hinde protsent on % : " + precent);
            }
            else if (precent > 50 && precent < 60)
            {
                Console.WriteLine("Tehtud! Hinne: D. Hind protsent on % " + precent);
            }
            else if (precent > 60 && precent < 75)
            {
                Console.WriteLine("Tehtud! Hinne: C. Hind protsent on %" + precent);
            }
            else if (precent > 75 && precent < 60)
            {
                Console.WriteLine("Tehtud! Hinne: B. Hind protsent on % " + precent);
            }
            else
            {
                Console.WriteLine("Tehtud! Hinne: A. Hind protsent on %" + precent);
            }
        }
    }
}