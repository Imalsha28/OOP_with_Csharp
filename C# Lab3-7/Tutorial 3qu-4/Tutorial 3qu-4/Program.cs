using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3qu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int sum = 0;

            for (int i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("the sum of the odd number from 1 to {0} is: {1}", num, sum);
            Console.ReadLine();

        }
    }
}
