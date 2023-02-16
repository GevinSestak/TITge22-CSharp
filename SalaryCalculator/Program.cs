using System.Transactions;

namespace SalaryCalculator
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
            Console.WriteLine("Neto sissetulek: " );
        }
    }
    public class Employee
    {
        public void SalaryCalculationLess1200(double brutoSalary)
        {
            double IncomeTax = 0.2;
            float TaxFreeIncome = 654;

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + pensionFond + unEmpTax));

            double netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

        }
        public double SalaryCalculationIsOver2100(double brutoSalary)
        {
            double IncomeTax = 0.2;
            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (pensionFond + unEmpTax));

            double netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

            return netIncome;
        }
        public double SalaryCalculationIsMiddle(double brutoSalary)
        {
            double IncomeTax = 0.2;
            double TaxFreeIncome = 654 - 0.72667 * (brutoSalary - 1200);
            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + pensionFond + unEmpTax));
            double netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);
            return netIncome;
        }
    }
}