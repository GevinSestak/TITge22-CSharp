namespace methodCall1
{
    internal class Program
    {
        string name, city;
        int age;

        static void Main(string[] args) {
            Console.Title = "Method call 1 EX";
            Console.WriteLine("Meetodi esile kutsumine");
            Program p = new();
            p.AcceptDetails();
            Console.ReadKey();
        }
        public void AcceptDetails() {
            Console.WriteLine("\nSisesta enda nimi:\t");
            name = Console.ReadLine();
            Console.WriteLine("\nSisesta oma kodulinn:\t");
            city = Console.ReadLine();
            Console.WriteLine("\nSisesta oma vanus:\t\t");
            age = Convert.ToInt32(Console.ReadLine());
            PrintDetails();
        }
        public void PrintDetails() {
            Console.Write("\n=======================");
            Console.Write("\nNimi:\t" + name);
            Console.Write("\nLinn:\t" + city);
            Console.Write("\nVanus:\t" + age);
            Console.Write("\n=======================");
        }
    }
}