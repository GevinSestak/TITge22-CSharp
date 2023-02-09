using System.Diagnostics;

namespace StopWatch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }
            stopwatch.Stop();
            Console.Write("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}