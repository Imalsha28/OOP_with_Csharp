using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2qu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine("The sum is " + sum);
            Console.ReadLine();

        }
    }
}
