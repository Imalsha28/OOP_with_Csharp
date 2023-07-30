using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_5qu_1
{
    internal class ArrayOperations
    {
        public void PerformOperations(int[] arr)
        {
            
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Minimum value: " + min);

           
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("Maximum value: " + max);

            
            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            double average = sum / arr.Length;
            Console.WriteLine("Average value: " + average);

            
            int[] reversedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }

            Console.WriteLine("Reverse order of values:");
            foreach (int num in reversedArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
