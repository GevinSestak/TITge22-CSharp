namespace Forloop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EX";
            int stringRowMin = 0;
            int stringRowMax = 5;
            int[] asterisk = new int[stringRowMax];

            Random randomAsterisk = new Random();

            for (int i = stringRowMin; i < asterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", randomAsterisk.Next(1, 20))));
            }
            Console.ReadKey();
        }
    }
}