namespace While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "While 3 EX";
            Console.WriteLine("While 3 EX");
            
            int i = 0, j = 1;

            while (i < 10) {
                Console.WriteLine("i = {0}", i);
                i++;
                while (j < 3) {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }
            }
            Console.ReadKey();
        }
    }
}