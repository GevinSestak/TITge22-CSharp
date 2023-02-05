namespace TempCelcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Temperatuur";
            Console.WriteLine("Sisesta temperatuur (C): ");
            string temp = Console.ReadLine();
            double parsedTemp = double.Parse(temp);

            Console.WriteLine("\nSisesta tuule kiirus (m/s): ");
            string windSpeed = Console.ReadLine();
            double windSpeedParse = double.Parse(windSpeed);

            Console.WriteLine("\nSisesta õhuniiskus: ");
            double humidityParsed = Double.Parse(Console.ReadLine());
            //double humidityParsed = double.Parse(humidity);

            double tempFeelsLike = parsedTemp + (0.33 * (humidityParsed / 100 * 6.105 * Math.Exp(17.27 * parsedTemp / (237.7 + parsedTemp)))) - (0.7 * (windSpeedParse / 5));
           // TEINE VALIK double tempFeelsLike = 13.12 + 0.6215 * temp - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temp * Math.Pow(windSpeed, 0.16);
            Console.WriteLine("Tajutav temp on: {0}", tempFeelsLike);
            Console.ReadKey();
        }
    }
}