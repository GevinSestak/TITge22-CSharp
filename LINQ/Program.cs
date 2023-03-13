using System;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LINQ - Language-Integrated Query";
            Console.WriteLine("LINQ - Language-Integrated Query");
            // Üle ühe järjestus.
            WhereLINQ();
            // Vanuse järgi selekteerimine
            ageLINQ();
            // ThenBy järgi reastamine
            thenByLINQ();
            // ThenByDescending järgi reastamine
            thenByDescending();
            // ToLookUp järgi reastamine
            toLookUpLINQ();
            // JoinLINQ
            joinLINQ();
            // GroupJoinLINQ
            GroupJoinLINQ();
            // Select In LINQ
            SelectLINQ();
            // All and Any LINQ
            AllAndAnyLINQ();
            // Contains LINQ
            ContainsLINQ();
            // Aggregated LINQ
            AggregateLINQ();
            // Average LINQ
            AverageLINQ();
            // Count LINQ
            CountLINQ();
            // Maximum LINQ
            MaximumLINQ();
            // SUM LINQ
            SumLINQ();
            // ElementAt LINQ
            ElementAtLINQ();
            // First LINQ
            FirstLINQ();
            // Last LINQ
            LastLINQ();
            // SequenceEqual
            SequenceEqualLINQ();
            // Concat
            ConcatLINQ();
            // DefaultIfEmpty
            DefaultIfEmptyLINQ();
            // Empty
            EmptyLINQ();
            // Range
            RangeLINQ();
            // Repeat LINQ
            RepeatLINQ();
            // Distinct LINQ
            DistinctLINQ();
            // Except LINQ
            ExceptLINQ();
            // Intersect
            IntersectLINQ();
            Console.ReadKey();
        }
        public static void WhereLINQ()
        {
            // Näitab nimekirjas üle ühe 
            var filteredResult = PeopleList.people.Where((s, i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });
            foreach (var people in filteredResult)
            {
                Console.WriteLine(people.Name);
            }
        }
        public static void ageLINQ()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Vanuse järgi selekteerimine");
            // Siin määrame ära mis vahemikus me otsime antud vanust
            var peopleByAge = PeopleList.people.Where(s => s.Age > 14 && s.Age < 25);
            foreach (var people in peopleByAge)
            {
                Console.WriteLine(people.Age + " " + people.Name);
            }
        }
        public static void thenByLINQ()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ThenBy järjestus");
            var thenByResult = PeopleList.people
                .OrderBy(x => x.Name)
                .ThenBy(y => y.Age);
            Console.WriteLine("ThenBy järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
        public static void toLookUpLINQ()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ToLookUp järgi reastamine:");

            var toLookUp = PeopleList.people
                .ToLookup(x => x.Age);
            foreach (var people in toLookUp)
            {
                Console.WriteLine("Vanuse grupp: " + people.Key);

                foreach (People p in people)
                {
                    Console.WriteLine("Nimi: {0}", p.Name);
                }
            }
        }
        public static void thenByDescending()
        {
            Console.WriteLine("\nThenByDescending järgi järjestus:");
            var thenByDescending = PeopleList.people
                .OrderBy(x => x.Name)
                .OrderByDescending(y => y.Age);
            foreach (var people in thenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
        public static void joinLINQ()
        {
            Console.WriteLine("\nInner join LINQ");
            var innerJoin = PeopleList.people.Join(
                GenderList.genderList,
                humans => humans.GenderId,
                gender => gender.Id,
                (humans, gender) => new
                {
                    Name = humans.Name,
                    Sex = gender.Sex
                });
            foreach (var obj in innerJoin)
            {
                Console.WriteLine("{0} - {1}", obj.Name, obj.Sex);
            }
        }
        public static void GroupJoinLINQ()
        {
            Console.WriteLine("\nGroupJoinLINQ");
            var groupJoin = GenderList.genderList.GroupJoin(
                PeopleList.people,
                p => p.Id,
                g => g.GenderId,
                (p, peopleGroup) => new
                {
                    Humans = peopleGroup,
                    GenderFullName = p.Sex
                });
            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.GenderFullName);
                foreach (var name in item.Humans)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }
        public static void SelectLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSelect LINQ");
            var selectResult = PeopleList.people.
                Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age
                });
            foreach (var item in selectResult)
            {
                Console.WriteLine("Nimi: {0}, Vanus: {1}", item.Name, item.Age);
            }
        }
        public static void AllAndAnyLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nAll LINQ");
            bool areallPeopleTeenagers = PeopleList.people
                .All(x => x.Age > 12);
            // Vastus tuleb true.
            Console.WriteLine(areallPeopleTeenagers);
            Console.WriteLine("\nAny LINQ");
            bool isAnyPersonTeenager = PeopleList.people.
                Any(x => x.Age < 20);
            // Kasvõi üks andmerida vastab tingimusele
            Console.WriteLine(isAnyPersonTeenager);

        }
        public static void ContainsLINQ()
        {
            Console.WriteLine("\nContains LINQ");
            // Pärib kas numbrite listis on vastav number olemas või mitte Contains(1) = TRUE ja kui pole Contains(10) = FALSE 
            bool result = NumberList.numberList.Contains(10);
            Console.WriteLine(result);
        }
        public static void AggregateLINQ()
        {
            Console.WriteLine("\nAggregated LINQ");
            // Samuti saab kasutada erinevaid funktsioone  y.Name.ToUpper() või siis isegi counti  y.Name.Count() Seda pead muutma seal kus on =>
            string commaSeparatedPersonNames = PeopleList.people
                .Aggregate<People, string>(
                "Inimeste nimed: ",
                (str, y) => str += y.Name + ", "
                );
            Console.WriteLine(commaSeparatedPersonNames);
        }
        public static void AverageLINQ()
        {
            Console.WriteLine("\nKesmine vanus");
            var averageResult = PeopleList.people
                .Average(x => x.Age);
            Console.WriteLine(averageResult);
        }
        public static void CountLINQ()
        {
            Console.WriteLine("\nCount");

            var totalPersons = PeopleList.people.Count();
            Console.WriteLine("Inimesi on kokku: " + totalPersons);

            var adultPersons = PeopleList.people
                .Count(x => x.Age >= 18);
            Console.WriteLine("Täisealisi inimesi on: " + adultPersons);
        }
        public static void MaximumLINQ()
        {
            Console.WriteLine("\nSuurima vanusega LINQ päring");
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);
            Console.WriteLine("Vanim inimene on " + oldestPerson);
        }
        public static void SumLINQ()
        {
            Console.WriteLine("\nVanuste summa");
            int ageSum = PeopleList.people
                .Sum(x => x.Age);
            Console.WriteLine("Inimeste vanuse summa: " + ageSum);

            Console.WriteLine("\nTäisealiste inimeste koondvanus");
            int sumAdult = 0;
            var numAdults = PeopleList.people.Sum(x =>
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
        public static void ElementAtLINQ()
        {
            Console.WriteLine("\nElementAt & OrDefault LINQ");
            // Loeb 4nda NIME listist sest hakkab lugema 0 = NAME 1, 1 = NAME 2, 2 = NAME 3 jne.
            string peopleName = PeopleList.people
                .Select(e => e.Name).ElementAt(3);
            Console.WriteLine("Inimese nimi: {0}", peopleName);
            // Loeb 4nda ID listist sest hakkab lugema 0 = ID 1, 1 = ID 2, 2 = ID 3 jne. Ja kui suurendada numbrit ja vastavalt sellele pole väärtus siis võtab esimese väärtuse ehk ID 0! 
            var res = PeopleList.people.
                Select(e => e.Id).ElementAtOrDefault(3);
            Console.WriteLine("Inimese ID: {0}", res);
            Console.WriteLine("----------------------------------");
        }
        public static void FirstLINQ()
        {
            Console.WriteLine("\nFirst & OrDefault LINQ");
            // Loeb esimese NIME PeopleListist
            string r = PeopleList.people.
                Select(r => r.Name).First();
            Console.WriteLine("Esimene nimi: {0}", r);
            // Loeb esimese NIME PeopleListist
            var res = PeopleList.people.
                Select(res => res.Age).FirstOrDefault();
            Console.WriteLine("Esimene vanus: {0}", res);
            Console.WriteLine("----------------------------------");
        }
        public static void LastLINQ()
        {
            Console.WriteLine("\nLast & OrDefault LINQ");
            // Loeb viimase nime PeopleListist
            var result = PeopleList.people
                .Select(e => e.Name).Last();
            Console.WriteLine("Viimane nimi: {0}", result);
            // Loeb viimase vanuse PeopleListist
            int result2 = PeopleList.people
                .Select(e => e.Age).LastOrDefault();
            Console.WriteLine("Viimane vanus: {0}", result2);
            Console.WriteLine("----------------------------------");
        }
        public static void SequenceEqualLINQ()
        {
            Console.WriteLine("\nSequenceEqual LINQ");
            // Siin tuleb TRUE väärtus vastuseks sest võrdleb samat listi ja nimesid. 
            var res = PeopleList.people.Select(e => e.Name).SequenceEqual(PeopleList.people.Select(e => e.Name));
            Console.WriteLine(res);
        }
        public static void ConcatLINQ()
        {
            Console.WriteLine("\nConcat LINQ");
            // Concat meetod kahe jada ühendamiseks üheks jadaks
            int[] addNumbers = { 6, 7, 11 };

            var combinedNumbers = NumberList.numberList.Concat(addNumbers);
            foreach (int num in combinedNumbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void DefaultIfEmptyLINQ()
        {
            Console.WriteLine("\nDefaultIfEmpty LINQ");
            int[] sequence1 = { };
            foreach (var val1 in sequence1.DefaultIfEmpty())
            {
                Console.WriteLine(val1);
            }
            string[] sequence2 = { "Martin", "Alo", "Rauno" };
            foreach (var val2 in sequence2.DefaultIfEmpty())
            {
                Console.WriteLine(val2);
            }
        }
        public static void EmptyLINQ()
        {
            Console.WriteLine("\nEmpty LINQ");
            var nonEmptyList = new List<int> { 1, 2, 3 };
            var emptyList = Enumerable.Empty<int>();
            Console.WriteLine("Non-empty list:");
            foreach (int num in nonEmptyList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Empty list:");
            foreach (int num in emptyList)
            {
                Console.WriteLine(num);
            }
        }
        public static void RangeLINQ()
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
        public static void RepeatLINQ()
        {
            Console.WriteLine("\nRepeat LINQ");
            // Siin prindib lihtsalt 5 Tere järjest. Tagumist numbrit suurendades saab neid rohkem printida.
            var repeated = Enumerable.Repeat("Tere", 5);
            foreach (string str in repeated)
            {
                Console.WriteLine(str);
            }
        }
        public static void DistinctLINQ()
        {
            Console.WriteLine("\nDistinct LINQ");
            var res = PeopleList.people
                .Select(e => e.Age).Distinct();
            Console.WriteLine("Vanused PeopleListis: ");
            foreach (var val in res)
            {
                Console.WriteLine(val);
            }
        }
        public static void ExceptLINQ()
        {
            Console.WriteLine("\nExcept LINQ");

            int[] numbersAdd = { 6, 7, 8, 13, 22 };
            var result = NumberList.numberList.Except(numbersAdd);
            Console.WriteLine("Numbrid esimeses jadas:");
            foreach (int number in NumberList.numberList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Numbrid teises jadas:");
            foreach (int number in numbersAdd)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Esimeses jadas olevad numbrid, mis ei ole teises jadas:");
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
        public static void IntersectLINQ()
        {
            Console.WriteLine("\nIntersect LINQ");
            var commonAges = PeopleList.people
                     .Select(p => p.Age)
                     .Intersect(PeopleList.people.Select(p => p.Age));
            Console.WriteLine("Inimesed sama vanusega");
            foreach (var age in commonAges)
            {
                var peopleWithSameAge = PeopleList.people.Where(p => p.Age == age);
                if (peopleWithSameAge.Count() > 1)
                {
                    Console.WriteLine("Vanus: {0}", age);
                    foreach (var person in peopleWithSameAge)
                    {
                        Console.WriteLine("Nimi: {0}", person.Name);
                    }
                }
            }
        }
    }
}