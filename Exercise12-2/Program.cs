using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //test 2 invoices of the same
                Invoice bucks1 = new Invoice("starbucks", 500.5);
                Invoice bucks2 = new Invoice("starbucks", 500.5);
                if (bucks1 == bucks2)
                {
                    Console.WriteLine("bucks1 bucks2 the same");
                }
                else
                {
                    Console.WriteLine("bucks1 bucks2 not the same");
                }
                

                //test 2 invoices of different vendor but same amount
                Invoice bucks3 = new Invoice("starbucks", 25.5);
                Invoice blenz1 = new Invoice("blenz", 25.5);
                if (bucks3 == blenz1)
                {
                    Console.WriteLine("bucks3 blenz1 the same");
                }
                else
                {
                    Console.WriteLine("bucks3 blenz1 not the same");
                }
                

                //test 2 invoices of same vendor but diff amount
                Invoice bucks4 = new Invoice("starbucks", 100);
                Invoice bucks5 = new Invoice("starbucks", 25.5);
                if (bucks3 == blenz1)
                {
                    Console.WriteLine("bucks4 bucks5 the same");
                }
                else
                {
                    Console.WriteLine("bucks4 bucks5 not the same");
                }

                //test 2 invoices of same amount but diff vendor
                Invoice bucks6 = new Invoice("starbucks", 25.5);
                Invoice blenz2 = new Invoice("blenz", 25.5);
                if (bucks3 == blenz1)
                {
                    Console.WriteLine("bucks6 blenz2 the same");
                }
                else
                {
                    Console.WriteLine("bucks6 blenz2 not the same");
                }

                Console.ReadKey();
            }
        }
    }
}
