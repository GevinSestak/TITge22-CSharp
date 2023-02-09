namespace methodCall2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MethodCall 2";
            Console.WriteLine("Näita maksimaalset numbrit");
            int a = 700, b = 400, ret;
            Program program = new Program();
            ret = program.DisplayMax(a, b);
            Console.Write("Maksimaalne väärtus: {0} ", ret);
            Console.ReadKey();
        }
        public int DisplayMax(int num1, int num2)
        {
            int result;
            if (num1 > num2) {
                result = num1;
            } else {
                result = num2;
            }
            return result;
        }
    }
}