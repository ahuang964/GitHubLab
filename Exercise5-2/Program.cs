using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum == 0)
            {
                Console.WriteLine("You entered 0");
            }
            if (inputNum%2 == 0)
            {
                Console.WriteLine("You entered even number");
            }
            if (inputNum%2 == 1)
            {
                Console.WriteLine("You enetered odd number");
            }
            if (inputNum%10 == 0)
            {
                Console.WriteLine("You entered multiple of 10");
            }
            if (inputNum > 100)
            {
                Console.WriteLine("The number you entered is too large");
            }
        }
    }
}
