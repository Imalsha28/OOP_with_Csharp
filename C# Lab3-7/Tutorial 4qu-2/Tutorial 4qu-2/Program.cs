using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4qu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());


            ConvertValues converter = new ConvertValues();
            converter.kilometerToMeter();


            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
