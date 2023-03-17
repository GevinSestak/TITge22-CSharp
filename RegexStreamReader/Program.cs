using System.Text;
using System.Text.RegularExpressions;

namespace RegexStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Regex StreamReader";
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("Kasuta formaati ´s--a´, kus -- tähistab tundmatut tähte");
        
            string choice = Console.ReadLine();
            WordFinder(choice);
        }
        private static void WordFinder(string choice)
        {
            Regex regularExpression = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            try
            {
                using (StreamReader sr = new StreamReader("D:/Dev/C#/TITge22-CSharp/RegexStreamReader/lemmad.txt", Encoding.Default))
                {
                    int lineNumber = 1;
                    while (sr.EndOfStream == false)
                    {
                        lineNumber++;   
                        string line = sr.ReadLine();
                        if (line.Length == choice.Length)
                        {
                            MatchCollection matchCollection = regularExpression.Matches(line);
                            if (matchCollection.Count > 0)
                            {
                                Console.WriteLine(lineNumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}