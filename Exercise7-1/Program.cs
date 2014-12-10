using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Add(3,6);
            Math.Subtract(6,3);
            Math.Multiply(2,5);
            Math.Divide(100,2);
        }
    }

    class Math
    {
        public static void Add(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
