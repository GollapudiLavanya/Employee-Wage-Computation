using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Wage Computation \n");

            CompanyEmpWage companyEmpWage = new CompanyEmpWage();
            companyEmpWage.addCompanyEmpWage("Lenovo", 10, 10, 200);
            companyEmpWage.addCompanyEmpWage("Apple", 10, 10, 200);
            companyEmpWage.computeEmpWage();
            Console.WriteLine("Total Wage of Lenovo Company : " + companyEmpWage.GetTotalWage("Lenovo"));
            Console.WriteLine("Total Wage of Apple Company : " + companyEmpWage.GetTotalWage("Apple"));
        }
    }
}