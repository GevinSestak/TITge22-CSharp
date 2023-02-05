namespace ForLoop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kill - koll kill - koll killadi - koll kill 
            // koll kill - kill - koll killadi - koll kill
            // kill-kol
            Console.Write("Palun sisesta korduste arv: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                
                string a = "kill-koll";
                string b = "koll-kill";
                string c = "killadi-koll";

                for (int v = 0; v < 2; v++)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(c);
                /*for (int v = 0; v <= number; v++)
                {
                    Console.WriteLine(a);
                }
                for (int d = 0; d <= number ; d++)
                {
                    Console.WriteLine(b);
                }
                for (int e = 0; e <= number; e++)
                {
                    Console.WriteLine(c);
                }*/
            }
        }
    }
}