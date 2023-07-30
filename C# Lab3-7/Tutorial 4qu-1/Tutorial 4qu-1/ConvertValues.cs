using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4qu_1
{
    internal class ConvertValues
    {
        public void kilometerToMeter()
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double meters = kilometers * 1000;

            Console.WriteLine("{0} kilometers is equal to {1} meters.", kilometers, meters);
        }

    }
}
