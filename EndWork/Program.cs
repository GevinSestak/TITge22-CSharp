using System;
using System.Net.Cache;

namespace EndWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lõputöö";
            Console.WriteLine("Sisesta NUMBRIGA valik mida soovid:");
            Console.WriteLine("1. LINQ (FirstOrDefault), Range, Sum & LastOrDefault");
            Console.WriteLine("2. If ja else");
            Console.WriteLine("3. Numbri püramiid");

            string choosedNumber = Console.ReadLine();

            switch (choosedNumber)
            {
                case "1":
                    LinqOption();
                    break;
                case "2":
                    ifAndElseOption();
                    break;
                case "3":
                    numberPyramid();
                    break;
                default:
                    Console.WriteLine("ERROR: Valikut ei tehtud!");
                    break;
            }
            Console.ReadKey();
        }
        private static void LinqOption()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sisesta NUMBRIGA valik mida soovid valida");
            Console.WriteLine("1. FirstOrDefault\n2. Range\n3. Sum\n4. LastOrDefault");

            string linqChoosed = Console.ReadLine();
            switch (linqChoosed)
            {
                case "1":
                    Console.WriteLine("\nFirstOrDefault");
                    FirstLINQ();
                    break;
                case "2":
                    Console.WriteLine("\nRange");
                    RangeLINQ();
                    break;
                case "3":
                    Console.WriteLine("\nSum");
                    SumLINQ();
                    break;
                case "4":
                    Console.WriteLine("\nLastOrDefault");
                    LastLINQ();
                    break;
                default:
                    Console.WriteLine("ERROR: Valikut ei tehtud!");
                    break;
            }
        }
        private class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        private static readonly List<People> people = new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "Jaak",
                Age = 13
            },
            new People()
            {
                Id = 2,
                Name = "Mati",
                Age = 12
            },
            new People()
            {
                Id = 3,
                Name = "Peeter",
                Age = 99
            },
        };
        private static void FirstLINQ()
        {
            Console.WriteLine("\nFirst & OrDefault LINQ");
            // Loeb esimese NIME
            string r = people.Select(r => r.Name).First();
            Console.WriteLine("Esimene nimi: {0}", r);
            // Loeb esimese VANUSE
            var res = people.Select(res => res.Age).FirstOrDefault();
            Console.WriteLine("Esimene vanus: {0}", res);
            Console.WriteLine("----------------------------------");
        }
        private static void RangeLINQ()
        {
            Console.WriteLine("\nRange LINQ");
            var age = Enumerable.Range(18, 20);
            Console.WriteLine("20 vanust alates 18-st:");
            foreach (var ages in age)
            {
                Console.WriteLine(ages);
            }
            Console.WriteLine("Selles listis on {0} vanust", age.Count());
        }
        private static void SumLINQ()
        {
            Console.WriteLine("\nVanuste summa");
            int ageSum = people.Sum(x => x.Age);
            Console.WriteLine("Inimeste vanuse summa: " + ageSum);

            Console.WriteLine("\nTäisealiste inimeste koondvanus");
            int sumAdult = 0;
            var numAdults = people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    sumAdult += x.Age;
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("Täiskasvanud isikute arv:" + numAdults);
            Console.WriteLine("Täiskasvanute koondvanuse tulemus:" + sumAdult);
        }
        private static void LastLINQ()
        {
            Console.WriteLine("\nLast & OrDefault LINQ");
            // Loeb viimase nime
            var result = people
                .Select(e => e.Name).Last();
            Console.WriteLine("Viimane nimi l: {0}", result);
            // Loeb viimase vanuse
            int result2 = people
                .Select(e => e.Age).LastOrDefault();
            Console.WriteLine("Viimane vanus: {0}", result2);
            Console.WriteLine("----------------------------------");
        }
        private static void ifAndElseOption()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sisestatud teksti salvestamine");
            Console.WriteLine("Sisesta soovitud valik NUMBRIGA");
            Console.WriteLine("1. Töötav versioon\n2. Vigane versioon");

            string ifAndElseChoosed = Console.ReadLine();
            switch (ifAndElseChoosed)
            {
                case "1":
                    Console.WriteLine("Töötav versioon valitud");
                    WorkingFileWrite();
                    break;
                case "2":
                    Console.WriteLine("Vigane versioon valitud");
                    NotWorkingFileWrite();
                    break;
                default:
                    Console.WriteLine("ERROR: Valikut ei tehtud");
                    break;
            }
        }
        private static void numberPyramid()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Numbri püramiid");
            Console.Write("Sisesta ridade arv: ");
            int i, j, spc, rows, k, t = 1;
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }
        }
        private static void WorkingFileWrite()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"D:\writeText.txt";
            Console.WriteLine("Sisesta tekst mida soovid kirjutada faili");

            string inputText = Console.ReadLine();
            try {
                if (!string.IsNullOrEmpty(inputText)) {
                    File.WriteAllText(filePath, inputText);
                    Console.WriteLine("Faili kirjutamine õnnestus!");
                } else {
                    Console.WriteLine("Sisestatud tekst oli tühi, midagi ei kirjutatud faili.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
        private static void NotWorkingFileWrite()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"V:\writeText.txt";
            Console.WriteLine("Sisesta tekst mida soovid kirjutada faili");

            string inputText = Console.ReadLine();
            try {
                if (!string.IsNullOrEmpty(inputText)) {
                    File.WriteAllText(filePath, inputText);
                    Console.WriteLine("Faili kirjutamine õnnestus!");
                } else {
                    Console.WriteLine("Sisestatud tekst oli tühi, midagi ei kirjutatud faili.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}