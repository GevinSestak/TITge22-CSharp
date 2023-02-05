namespace WhileDo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "While DO EX";
            Console.WriteLine("While DO function");

            int i = 1, n = 5, result;
            do {
                result = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, result);
                i++;
            } while (i<=10);
            Console.ReadKey();
        }
    }
}