using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3qu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int ans;

            ans = (num % 2);

            if (ans == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("odd");
            Console.ReadLine();


        }

    }
}

