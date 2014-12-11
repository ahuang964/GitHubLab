using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_3And8_4
{
    class Tester
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Enter a number:");
            double gg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Double of your input is: {0}\nTriple of your input is: {1}", gg*2, gg*3);
        }
    }
}
