using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2qu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, sub, multi, div;
            Console.WriteLine("Enter the first number: ");
                         int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
                         int num2 = int.Parse(Console.ReadLine());
            
            sum = num1 + num2;
            sub = num1 - num2;
            multi = num1 * num2;
            div = num1 / num2;
            
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The subtraction is " + sub);
            Console.WriteLine("The multipication is " + multi);
            Console.WriteLine("The division is " + div);
            Console.ReadLine();

        }
    }
}
