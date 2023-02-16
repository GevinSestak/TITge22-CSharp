namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine("-------------------------------------------------");
            IDictionary<int, string> resultNames = new Dictionary<int, string>();
            resultNames.Add(1, "One");
            resultNames.Add(2, "Two");
            resultNames.Add(3, "Three");
            resultNames.Add(4, "Four");

            foreach(KeyValuePair<int, string> kvp in resultNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("-------------------------------------------------");
            var cities = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "FIN", "Helsinki, Turu, Oulu" },
                { "LAT", "Riga, Daugavpils, Jurmala" },
            };
            int i = 0;
            foreach (var kvp in cities)
            {
                i++;
                Console.WriteLine("Key: {0}, Value: {1}, NR: {2}", kvp.Key, kvp.Value, i);
            }
            Console.WriteLine("------------------------------------------------");
            // Asendab linnad ära esimeses listis
            var linnad = new Dictionary<string, string>()
            {
                { "EST", "Tallinn, Tartu, Pärnu" },
                { "FIN", "Helsinki, Turu, Oulu" },
                { "LAT", "Riga, Daugavpils, Jurmala" },
            };

            linnad["EST"] = "Võru, Paldiski";
            linnad["FIN"] = "Tampere, Porvo";

            foreach (var kvp in linnad) {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("-------------------------------------------------");
            
            // Kustutab listist EST
            linnad.Remove("EST");
            Console.WriteLine("Total elements: {0}", linnad.Count);
            // Puhastab kogu listi
            linnad.Clear();
            Console.WriteLine("Elemente peale Clear funktsiooni: {0}", linnad.Count);
            Console.ReadKey();
        }
    }
}