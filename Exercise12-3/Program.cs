using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice bucks1 = new Invoice("starbucks", 500.5);
            Invoice bucks2 = new Invoice("starbucks", 100);
            if (bucks1 > bucks2)
            {
                Console.WriteLine("bucks1 bigger than bucks2");
            }
            else
            {
                Console.WriteLine("wrong");
            }

            Invoice bucks3 = new Invoice("starbucks", 50);
            Invoice bucks4 = new Invoice("starbucks", 100);
            if (bucks3 < bucks4)
            {
                Console.WriteLine("bucks3 smaller than bucks4");
            }
            else
            {
                Console.WriteLine("wrong");
            }

            Console.ReadKey();
        }
    }
}
