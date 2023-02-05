namespace Array6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array 6";
            int[] arr = new int[10];
            
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("--------------------------------");
            int[] arr2 = { 10, 20, 30, 40, 50 };

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("While");
            
            int[] arrayItem;
            arrayItem = new int[5];

            arrayItem[0] = 10;
            arrayItem[1] = 20;
            arrayItem[2] = 30;
            arrayItem[3] = 40;
            arrayItem[4] = 50;

            int j = 0;
            while (j < arrayItem.Length)
            {
                Console.WriteLine(arrayItem[j]);
                j++;
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Do ja while");
            int k = 0;

            do
            {
                Console.WriteLine(arrayItem[k]);
                k++;
            } while (k < arrayItem.Length);
            Console.ReadKey();
        }
    }
}