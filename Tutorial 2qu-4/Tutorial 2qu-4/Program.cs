using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2qu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ans;
            Console.WriteLine("Enter a number :");
            int num = int.Parse(Console.ReadLine());

            ans = num % 2;

            if (ans == 0)
                Console.WriteLine("The number is even number");
            else
                Console.WriteLine("The number is odd number");
            Console.ReadLine();

        }
    }
}
