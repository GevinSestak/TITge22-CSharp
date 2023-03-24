namespace InheritanceCarChatGPTVersion
{
    public enum CarBrand
    {
        BMW = 1,
        Volvo,
        Audi
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Auto päring";
            Console.WriteLine("Sisesta margi number, et teada saada VIN-kood");
            Console.WriteLine("1. BMW\n2. Volvo\n3. Audi");

            int carNumber;
            if (!int.TryParse(Console.ReadLine(), out carNumber))
            {
                Console.WriteLine("Sisestatud väärtus pole sobiv!");
                return;
            }

            Cars vinCode = new Cars();
            try
            {
                string vin = vinCode.GetVin((CarBrand)carNumber);
                Console.WriteLine("Edukas päring!");
                Console.WriteLine($"{((CarBrand)carNumber).ToString()} VIN kood: {vin}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Viga päringu töötlemisel!");
                // Log the error message to a file or database
            }

            Console.ReadKey();
        }
    }

    public class Machine
    {
        private int chosenCar;

        public void SetChosenCar(int carNumber)
        {
            chosenCar = carNumber;
        }

        public int GetChosenCar()
        {
            return chosenCar;
        }
    }

    public class Cars : Machine
    {
        public string GetVin(CarBrand brand)
        {
            switch (brand)
            {
                case CarBrand.BMW:
                    return "123423423asfdasdfvdf3";
                case CarBrand.Volvo:
                    return "12342342sdfS3";
                case CarBrand.Audi:
                    return "12QERGSEF3";
                default:
                    throw new ArgumentException("Vigane margi number!");
            }
        }
    }
}
