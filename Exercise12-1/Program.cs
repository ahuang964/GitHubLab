using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add 2 invoices of the same vendor
            Invoice bucks1 = new Invoice("starbucks", 500.5);
            Invoice bucks2 = new Invoice("starbucks", 125.3);
            Console.WriteLine("Sum of 2 invoices from starbucks: {0} + {1} = {2}", bucks1, bucks2, bucks1+bucks2);

            //add 2 invoices of different vendor
            Invoice bucks3 = new Invoice("starbucks", 25.5);
            Invoice blenz1 = new Invoice("blenz", 75.3);
            Console.WriteLine("Sum of 2 invoices from starbucks and blenz: {0} + {1} = {2}", bucks3, blenz1, bucks3 + blenz1);

            Console.ReadKey();
        }
    }
}
