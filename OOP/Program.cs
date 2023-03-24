namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "OOP";
            Console.WriteLine("Sisesta 2 numbrit");

            Console.WriteLine("Esimene number: ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Teine number: ");
            int secondNr = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(firstNr);
            rectangle.SetHeight(secondNr);

            Console.WriteLine("Pindala: {0}", rectangle.GetArea());
            Console.ReadKey();
        }
    }
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}