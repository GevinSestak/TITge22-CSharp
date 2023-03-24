namespace Polymorphism3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism: Engine status";
            Machine EngineOff = new Machine();
            Machine car = new Car();
            Machine boat = new Boat();

            EngineOff.EngineStart();
            car.EngineStart();
            boat.EngineStart();

            Console.ReadKey();
        }
    }
    class Machine
    {
        public virtual void EngineStart()
        {
            Console.WriteLine("Engine status: OFF");
        }
    }
    class Car : Machine
    {
        public override void EngineStart()
        {
            Console.WriteLine("Engine status: ON");
        }
    }
    class Boat : Machine
    {
        public override void EngineStart()
        {
            Console.WriteLine("Engine status: ON");
        }
    }
}