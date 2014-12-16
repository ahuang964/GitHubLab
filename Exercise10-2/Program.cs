using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please input a number:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You just entered:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number {0}: {1}", i+1, numbers[i]);
            }
        }
    }
}
