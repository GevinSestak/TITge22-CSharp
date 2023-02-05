namespace Masiiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Masiiv EX";

            string sentence = "Euroopa üks pealinnadest on: ";

            // Näide 1
            var citys = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsinki");
            // Siin ütlen ette, et võtaks citys.Item1 väärtusega! Võib muuta nrit.
            Console.WriteLine(sentence + citys.Item1);
            Console.WriteLine("---------------------");

            // Näide 2
            string[] city = {"Tallinn", "Pariis", "Rooma", "London", "Helsinki"};
            // Siin toob kõik välja mis on listis FOR loopiga.
            for (int i = 0; i < city.Length; i++) {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("---------------------");

            // Näide 3
            string[] cityList = { "Tallinn", "Pariis", "Rooma", "London", "Helsinki" };
            Console.WriteLine(sentence + city[3]);

            // Näide 4
            Random number = new Random();
            int randomNumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomNumber]);
            
            Console.ReadKey();
        }
    }
}