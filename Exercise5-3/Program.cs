using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            switch (inputNum)
            {
                case 0:
                    Console.WriteLine("You entered 0");
                    break;
            }

            int mod2 = inputNum%2;
            switch (mod2)
            {
                case 0:
                    Console.WriteLine("You entered even number");
                    break;
                case 1:
                    Console.WriteLine("You enetered odd number");
                    break;
            }

            int mod10 = inputNum%10;
            switch (mod10)
            {
                case 0:
                    Console.WriteLine("You entered multiple of 10");
                    break;
            }

            bool toLarge = inputNum > 100 ? true : false;
            switch (toLarge)
            {
                case true:
                    Console.WriteLine("The number you entered is too large");
                    break;
            }
        }
    }
}
