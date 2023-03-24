namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism";
            Console.WriteLine("Polymorphism");

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.GetInfo();

            BaseClass baseClass = new BaseClass();
            baseClass.GetInfo();

            Console.WriteLine("Press Enter and exit the program");
            Console.ReadKey();
        }
    }
    public class BaseClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Tere tulemast progremisse");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Õpid C# keelt");
        }
    }
}