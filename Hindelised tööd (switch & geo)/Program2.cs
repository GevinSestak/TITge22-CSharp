namespace WeekdayEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Number ja nädalapäev";
            Console.WriteLine("Sisesta number 1-7ni, et teada saada nädalapäev");

            int weekDay = int.Parse(Console.ReadLine());
            switch (weekDay) {
                    case 1:
                        Console.WriteLine("Esimene päev nädalas on esmaspäev. Haigusleht äkki?");
                        break;
                    case 2:
                        Console.WriteLine("Teine päev nädalas on teisipäev. Peaaegu nädala selgroo murtud.");
                        break;
                    case 3:
                        Console.WriteLine("Kolmas päev nädalas on kolmapäev. Tartus tudengid juba peavad pidu.");
                        break;
                    case 4:
                        Console.WriteLine("Neljas päev nädalas on neljapäev. Homme saab niisutada kurku!");
                        break;
                    case 5:
                        Console.WriteLine("Viies päev nädalas on reede. PARTY!!!");
                        break;
                    case 6:
                        Console.WriteLine("Kuues päev nädalas on laupäev. Pohmakas vol 1");
                        break;
                    case 7:
                        Console.WriteLine("Seitsmes päev nädalas on pühapäev. Valmistu tööks!");
                        break;
                default:
                    Console.Beep();
                    Console.WriteLine("ERROR: Sisesta arv 1-7ni!");
                    break;
            }
            Console.ReadKey();
        }
    }
}