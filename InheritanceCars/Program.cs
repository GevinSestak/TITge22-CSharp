namespace InheritanceCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Auto päring";
            Console.WriteLine("Sisesta margi number, et teada saada VIN-kood");
            Console.WriteLine("1. BMW\n2. Volvo\n3. Audi");

            int carNumber = Convert.ToInt32(Console.ReadLine());

            Cars vinCode = new Cars();
            vinCode.PrintVin(carNumber);
            Console.ReadKey();
        }
    }
    class Machine
    {
        public void ChoosedCar(int f) {
            chosenCar = f;
        }
        protected int chosenCar;
    }
    class Cars : Machine
    {
        public void PrintVin(int chosenCar)
        {
            if(chosenCar == 1) {
                SuccessInfo();
                Console.WriteLine("BMW VIN kood: 123423423asfdasdfvdf3");
            }
            else if (chosenCar == 2) {
                SuccessInfo();
                Console.WriteLine("Volvo VIN kood: 12342342sdfS3");
            }
            else if (chosenCar == 3) {
                SuccessInfo();
                Console.WriteLine("Audi VIN kood: 12QERGSEF3");
            } else {
                Console.WriteLine("Siukest valikut ei eksisteeri!");
            }
        }
        public void SuccessInfo() {
            Console.WriteLine("Edukas päring!");
        }
    }
}