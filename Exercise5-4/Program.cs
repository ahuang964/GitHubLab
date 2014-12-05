using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 25;
            while (i <= j)
            {
                Console.WriteLine("i = {0} AND j = {1}", i, j);
                i++;
                j--;
            }
            Console.WriteLine("Crossed over!");
        }
    }
}
