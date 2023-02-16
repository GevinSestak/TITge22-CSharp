namespace SalaryCalc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta brutopalk: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());
            Employee emp = new Employee();

            if (brutoSalary <= 1200) {
                emp.SalaryCalculationLess1200(brutoSalary);
            }
            else if (brutoSalary >= 1200.01 && brutoSalary <= 2100) {
                emp.SalaryCalculationIsMiddle(brutoSalary);
            }
            else if (brutoSalary >= 2100.01) {
                emp.SalaryCalculationIsOver2100(brutoSalary);
            } else {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("Pensioni fond: " + emp.PensionFond);
            Console.WriteLine("Töötuskindlustus: " + emp.UnEmpTax);
            Console.WriteLine("Neto sissetulek: " + emp.NetIncome);
        }
    }
    public class Employee
    {
        public double PensionFond { get; set; }
        public double UnEmpTax { get; set; }
        public double IncomeTaxSum { get; set; }
        public double NetIncome { get; set; }

        public void SalaryCalculationLess1200(double brutoSalary)
        {
            double IncomeTax = 0.2;
            float TaxFreeIncome = 654;

            PensionFond = brutoSalary * 0.02;
            UnEmpTax = brutoSalary * 0.016;
            IncomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + PensionFond + UnEmpTax));
            NetIncome = brutoSalary - (PensionFond + UnEmpTax + IncomeTaxSum);
        }
        public void SalaryCalculationIsOver2100(double brutoSalary)
        {
            double IncomeTax = 0.2;

            PensionFond = brutoSalary * 0.02;
            UnEmpTax = brutoSalary * 0.016;
            IncomeTaxSum = IncomeTax * (brutoSalary - (PensionFond + UnEmpTax));
            NetIncome = brutoSalary - (PensionFond + UnEmpTax + IncomeTaxSum);
        }
        public void SalaryCalculationIsMiddle(double brutoSalary)
        {
            double IncomeTax = 0.2;
            double TaxFreeIncome = 654 - 0.72667 * (brutoSalary - 1200);

            PensionFond = brutoSalary * 0.02;
            UnEmpTax = brutoSalary * 0.016;
            IncomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + PensionFond + UnEmpTax));
            NetIncome = brutoSalary - (PensionFond + UnEmpTax + IncomeTaxSum);
        }
    }
}