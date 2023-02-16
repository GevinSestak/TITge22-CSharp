namespace ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ValueTuple";
            Console.WriteLine("ValueTuple");

            ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
            Console.WriteLine(person1);
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);
            Console.WriteLine("------------------------");
            (int, string, string) person2 = (1, "James", "Bond");
            Console.WriteLine(person2);
            Console.WriteLine(person2.Item1);
            Console.WriteLine(person2.Item2);
            Console.WriteLine(person2.Item3);
            Console.WriteLine("------------------------");

            (int id, string firstName, string lastName) person = (1, "Mati", "Nuude");
            Console.WriteLine(person);
            Console.WriteLine(person.id);
            Console.WriteLine(person.firstName);
            Console.WriteLine(person.lastName);
            Console.WriteLine("------------------------");
            (int id1, string firstName1, string lastName1) person3 = (Personid1: 1, firstN: "Jaan", lastN: "Murakas");
            Console.WriteLine(person3);
            Console.WriteLine(person3.id1);
            Console.WriteLine(person3.firstName1);
            Console.WriteLine(person3.lastName1);
            Console.WriteLine("------------------------");

            (string, string, int) person4 = (firstN: "Peeter", lastN: "Võsa", Personid1: 1);
            Console.WriteLine(person4);
            Console.WriteLine(person4.Item1);
            Console.WriteLine(person4.Item2);
            Console.WriteLine(person4.Item3);
            Console.WriteLine("------------------------");

            var primeMinister = GetPerson();
            Console.WriteLine(GetPerson());
            Console.WriteLine("{0}, {1}, {2}", primeMinister.Item1, primeMinister.Item2, primeMinister.Item3);
            
            Console.WriteLine("------------------------");
            
            var minister2 = GetPerson2();
            // Kaks erinevat printimis versiooni kuidas saab teha
            Console.WriteLine("{0}, {1}, {2}", minister2.Item1, minister2.Item2, minister2.Item3);
            Console.WriteLine("{0}, {1}, {2}", minister2.id, minister2.firstName, minister2.lastName);

            Console.ReadKey();
        }
        // ValueTuple return 
        static (int, string, string) GetPerson()
        {
            return (1, "Kaja", "Kallas");
        }
        static (int id, string firstName, string lastName) GetPerson2()
        {
            return (id: 1, firstName: "Jaak", lastName: "Aab");
        }
    }
}