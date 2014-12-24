using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>();
            int i = 0;
            fibonacci.Add(1);
            int j = 1;
            fibonacci.Add(2);
            int max = 4000000;
            double evenValuedSum = 2;

            while (fibonacci[i] + fibonacci[j]<max)
            {
                fibonacci.Add(fibonacci[i] + fibonacci[j]);
                i++;
                j++;
                if (fibonacci[j]%2 == 0)
                {
                    evenValuedSum+=fibonacci[j];
                }
                
            }

            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, the sum of the even-valued terms is " + evenValuedSum);
        }
    }
}
