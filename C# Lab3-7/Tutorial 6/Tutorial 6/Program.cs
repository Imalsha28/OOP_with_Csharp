using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            ArrayHelper arrayHelper = new ArrayHelper();
            int[] array = arrayHelper.CreateArrayWithZeroes(size);

            Console.WriteLine("Enter values for the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Value {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("0");
            }

            Console.WriteLine("\nValues in the array:");

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }

    class ArrayHelper
    {
        public int[] CreateArrayWithZeroes(int size)
        {
            int[] array = new int[size];
            return array;
        }
    }
}

