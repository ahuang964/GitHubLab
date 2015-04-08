using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Meter m1 = new Meter(100);
            Foot f1 = new Foot(60);

            Foot f2 = (Foot) m1;
            Meter m2 = (Meter) f1;

            Console.WriteLine("{0} is {1}\n", m1, f2);
            Console.WriteLine("{0} is {1}\n", f1, m2);

            Console.ReadLine();
        }
    }
}
