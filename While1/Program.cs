namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "While";
            Console.WriteLine("While");

            int i = 0;
            while (i < 10) {
                Console.WriteLine("i = {0}", i);
                i++;
            }
            Console.ReadKey();
        }
    }
}