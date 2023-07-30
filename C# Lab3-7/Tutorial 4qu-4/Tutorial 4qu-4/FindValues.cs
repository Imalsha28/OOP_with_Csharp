using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4qu_4
{
    internal class FindValues
    {
        public double FindArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        
        public double FindCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

    }
}
