using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_4
{
    class Program
    {
        private const int radius = 5;
        private const float Pi = (float)3.14159;

        static void Main(string[] args)
        {
            double surface = 4 * Pi * (radius*radius);
            double volume = (4/3)*Pi*(radius*radius*radius);

            Console.WriteLine("{0} is greater.", surface>volume?"Surface":"Volume");
        }
    }
}
