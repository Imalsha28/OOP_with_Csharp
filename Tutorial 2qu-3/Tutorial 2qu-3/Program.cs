using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2qu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 8;
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("The area of the circle is {0}.", area);
            Console.WriteLine("The circumference of the circle is {0}.", circumference);
            Console.ReadLine();

        }
    }
}
