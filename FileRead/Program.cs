namespace FileRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "File reader";
            Console.WriteLine("Faili lugemine");

            try
            {
                // Fail kaustas
                using (StreamReader sr = new StreamReader("D:/Dev/C#/TITge22-CSharp/FileRead/read.txt"))
                {
                    string line = sr.ReadToEnd();
                    string[] names = line.Split("\n");
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    Console.WriteLine();
                    Array.Sort(names); // Sorteerib massiivi ära.
                    Console.WriteLine("Sorteeritud nimekiri");
                    foreach (string sortedNames in names)
                    {
                        Console.WriteLine(sortedNames);
                    }
                    sr.Close();

                    // Loob faili samasse kausta uue nimega
                    using (StreamWriter streamWriter = new StreamWriter("D:/Dev/C#/TITge22-CSharp/FileRead/read1.txt", true))
                    {
                        int i = 1;
                        foreach (string name in names) 
                        {
                            streamWriter.WriteLine(i + "." + name);
                            i++;
                        }
                        streamWriter.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}