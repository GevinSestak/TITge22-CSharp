namespace While4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While 4");
            int i = 1, sum = 0;

            while (i <= 5) {
                sum += i;
                i++;
            }
            Console.WriteLine("SUM = {0}", sum);
        }
    }
}