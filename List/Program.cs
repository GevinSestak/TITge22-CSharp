using System.Collections.Immutable;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");
            IList<Person> person = new List<Person>()
            {
                new Person() { Id = 1, Name = "Mati", Age = 30 },
                new Person() { Id = 2, Name = "Juhan", Age = 9 },
                new Person() { Id = 3, Name = "Kalle", Age = 99 },
                new Person() { Id = 4, Name = "Manna", Age = 10 },
            };

            var persons = from s in person
                          select new 
                          { 
                              Id = s.Id,
                              Name = s.Name, 
                              Age= s.Age 
                          };
            foreach(var per in persons)
            {
                Console.WriteLine("ID on: " + per.Id + "\nNimi on: " + per.Name);
            }
            Console.WriteLine("---------------VARIANT 2----------------");
            Console.WriteLine("LINQ SELECT e teine variant on teha LINQ päring");

            var result = person
                //.Where(p => p.Id == 1) // Toob aint ID 1 isiku sest määrame p.ID == 1
                //.Where(y => y.Id == 1 || y.Age == 99) // Näen ainult ID 1ga isikut või kelle vanus on 99
                .OrderBy(y => y.Name) // Järjestab tähestiku järgi nimed ära / sorteerib
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age,
                    Id = x.Id
                });
            foreach (var per in result)
            {
                Console.WriteLine("ID on: " + per.Id + "\nNimi on: " + per.Name);
            }
            Console.WriteLine("------------------------");
            // Kuvab gruppide kaupa ja antud juhul paneb vanused gruppidesse ehk tulemuseks on kolm rida andmeid kuna kaks isikut on 9a
            Console.WriteLine("Kasutame GroupBy sorteerimist");
            var groupBy = person
                .GroupBy(x => x.Age);

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key );
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}