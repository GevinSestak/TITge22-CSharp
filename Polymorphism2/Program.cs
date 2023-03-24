namespace Polymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism";
            Console.WriteLine("Polymorphism");
            
            Animal animal = new Animal(); // objekti Animal loomine
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.AnimalSound();
            pig.AnimalSound();
            dog.AnimalSound();

            Console.ReadKey();
        }
    }
    class Animal // Base Class
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes sound");
        }
    }
    class Pig : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: RÖH-RÖH-RÖH");
        }
    }
    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The dog says: AUH-AUH-AUH");
        }
    }
}