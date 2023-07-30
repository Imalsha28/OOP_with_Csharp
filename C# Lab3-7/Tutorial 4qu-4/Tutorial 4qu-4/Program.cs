using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4qu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Area and Circumference Calculator");
            Console.WriteLine(" ");

           
            Console.Write("Enter the radius of the circle: ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number for the radius.");
                Console.Write("Enter the radius of the circle: ");
            }

           
            FindValues circleValues = new FindValues();

            
            double area = circleValues.FindArea(radius);
            double circumference = circleValues.FindCircumference(radius);

            Console.WriteLine(" ");
            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");
        }
    }
    }

