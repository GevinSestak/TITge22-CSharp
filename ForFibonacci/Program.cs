namespace ForFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci number");
            Console.WriteLine("Sisesta numbrid");

            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 0, c = 1;
            for (int i = 3; i <= n; i++) {
                Console.WriteLine(a);
                a = b + c;
                c = b;
                b = a;
            }
            Console.ReadKey();
        }
    }
}