namespace FileWriteAllText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "File write from console";
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"D:\Dev\C#\TITge22-CSharp\FileWriteAllText\writeText.txt";
            Console.WriteLine("Sisesta tekst mida soovid kirjutada faili");
            
            string inputText = Console.ReadLine();
            
            File.WriteAllText(filePath, inputText);
            Console.ReadKey();
        }
    }
}