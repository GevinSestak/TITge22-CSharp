namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");

            SortedList<int, string> numbrid = new SortedList<int, string>()
            {
                {3, "Three" },
                {5, "Five" },
                {9, "Nine" },
                {1, "One" }
            };
            Console.WriteLine("Algne key value");

            foreach (KeyValuePair<int, string> kvp in numbrid)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Lisame numbreid juurde ja järjestab taaskord ära");
            // Lisame numbreid juurde
            numbrid.Add(6, "Six");
            numbrid.Add(2, "Two");
            numbrid.Add(4, "Four");

            foreach (KeyValuePair<int, string> kvp in numbrid)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }


            SortedList<string, string> words = new SortedList<string, string>()
            {
                {"Tallinn", "EST" },
                {"Helsinki", "FIN" },
                {"London", "UK" },
            };
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Algne key value");

            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Lisame kaks linna juurde");
            // Kui lisame kaks linna juurde, siis paneb need ka järjestikusse
            words.Add("New York", "USA");
            words.Add("Brazil", "BRA");
            foreach (KeyValuePair<string, string> kvp in words)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}