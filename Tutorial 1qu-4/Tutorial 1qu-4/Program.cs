using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1qu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the salary of the employee: ");
            double salary = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter the tax rate: ");
            double taxRate = double.Parse(Console.ReadLine());

           
            double salaryAfterTax = salary - (salary * taxRate);

            
            Console.WriteLine("The salary after tax is: {0:f2}" + salaryAfterTax);
            Console.ReadLine();

        }
    }
}
