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
            // Kavõi üks andmerida vastab tingimusele
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
                    // KODUS VAJA TEADA TÄISKASVANUTE KOONDVANUST
                    //sumAdult = PeopleList.people.Sum(x => x.Age);
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
    }
}