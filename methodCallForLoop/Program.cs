namespace methodCallForLoop
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Title = "matrixforLoop";
            int[,] matrix = new int[10, 2];
            FillMatrix(matrix);
            Console.ReadKey();
        }
        public static void FillMatrix(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    var result = matrix[i, j] = -1;
                    Console.WriteLine(result);
                }
            }
        }
    }
}