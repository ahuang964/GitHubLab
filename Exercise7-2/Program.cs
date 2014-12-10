using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Math myMath = new Math();
            myMath.Add(3, 6);
            myMath.Subtract(6, 3);
            myMath.Multiply(2, 5);
            myMath.Divide(100, 2);
        }
        
    }

    class Math
    {
        public void Add(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public void Subtract(double a, double b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        public void Divide(double a, double b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
