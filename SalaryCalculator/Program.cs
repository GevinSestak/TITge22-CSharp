namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Program();
            p.SalaryCalculation();
        }
    }
    public static class Employee
    {
        public static double SalaryCalculation()
        {
            float brutoIncome = 2000;
            double IncomeTax = 0.2;

            float TaxFreeIncome = 654;

            double deductibleIncome = brutoIncome - TaxFreeIncome;
            double taxSum = deductibleIncome * IncomeTax;
            double netIncome = brutoIncome - taxSum;

            return netIncome;
        }
    }
}