namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enum";
            Console.WriteLine("Enum");

            Console.WriteLine("------------------------------");
            Console.WriteLine(WeekDays.Esmaspäev);
            Console.WriteLine("------------------------------");
            // Tagastab väärtuse numbrilisena
            int day = (int)WeekDays.Reede;
            Console.WriteLine(day);


            Console.WriteLine("------------------------------");
            var weekDay = (WeekDays)5;
            Console.WriteLine(weekDay);
            
            Console.WriteLine("------------------------------");
            int color = (int)Colors.Blue;
            Console.WriteLine(color);

            // Lubab ainult sisestada väärtuseid mis on enum classis defineeritud
            int colorWrongNr = (int)Colors.Yellow;
            Console.WriteLine(colorWrongNr);
            // See annab errorit kui kasutada
            // int colorWrongNr = (Colors)1;
            // cw(colorWrongNr)
            Console.ReadKey();
        }
        enum WeekDays {
            Esmaspäev,
            Teisipäev,
            Kolmapäev,
            Neljapäev,
            Reede,
            Laupäev,
            Pühapäev
        }
        enum Colors {
            Red = 3,
            Green = 10, 
            Blue = 100,
            Yellow = 12,
            YellowGreen = 323,
            Black = 8,
            White = 1
        }
    }
}