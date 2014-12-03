using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st time:\n");
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("{0},", counter);
                counter++;
            }
            Console.WriteLine("\n");
            //2nd time
            Console.WriteLine("2nd time:\n");
            counter = 1;
            do
            {
                Console.WriteLine("{0},", counter);
                counter++;
            } while (counter <= 10);
            Console.WriteLine("\n");
            //3rd time
            Console.WriteLine("3rd time:\n");
            for (counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("{0},", counter);
            }
        }
    }
}
