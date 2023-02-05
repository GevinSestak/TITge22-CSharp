namespace While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "While 2";
            Console.WriteLine("While 2");

            byte i = 0;

            // Lõputu tsükkel kuna tingimus on TRUE
            while (true) {
                // Näitab tulemust konsoolis
                Console.WriteLine("i = {0}", i);
                // Liidab koguaeg +1
                i++;
                // Kui I on SUUREM kui 10 siis lõhub BREAK-iga ehk siis the end
                if (i > 10) {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}