namespace Array5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ain", "Olev", "Kalev", "Martin", "George" };

            var stringToFind = "olev";

            string[] result = Array.FindAll(names, x => x.ToLower() == stringToFind);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}