using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_5qu_5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            // Input values to the array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter the value for element {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            ArrayOperations arrayOps = new ArrayOperations();
            arrayOps.PerformOperations(array);


            Console.ReadKey();

        }
    }
}
