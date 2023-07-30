using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_3qu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "NSBM green university";
            int vowelCount = 0;
            string vowels = "aeiouAEOU";

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in the string is: {0}", vowelCount);
            Console.ReadLine();
        }

    }
}

