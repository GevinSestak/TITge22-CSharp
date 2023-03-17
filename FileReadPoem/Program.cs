using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace FileReadPoem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "File read poem";

            try
            {
                // Fail kaustas
                using (StreamReader sr = new StreamReader("D:/Dev/C#/TITge22-CSharp/FileReadPoem/luuletus.txt"))
                {
                    string line = sr.ReadToEnd();
                    string[] poemLine = line.Split("\n");
                    int i = 1;
                    foreach (string row in poemLine)
                    {
                        // Loeb valesti tähemärke aga teeb töö ära. Lihtsalt siin tuleb vale vastus. Regexiga tuleb õige märkide arv
                        /* 
                            int symbolsCount = row.Trim().Length; // Eemalda tühikud rea algusest ja lõpust, seejärel loe tähemärkide arv
                            Console.WriteLine(i + ". " + row.Trim() + " - " + symbolsCount + " tähemärki");
                            i++;
                        */
                        string rowWithoutSpaces = Regex.Replace(row, @"\s+", ""); // Eemalda tühikud reast
                        int symbolsCount = rowWithoutSpaces.Length;
                        Console.WriteLine(i + ". " + row.Trim() + " - " + symbolsCount + " tähemärki");
                        i++;
                    }
                    Console.WriteLine();
                    sr.Close();
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