using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_1
{
    class Tester
    {
        static void Main(string[] args)
        {
            int i = 5;
            float f = (float)3.1;

            Console.WriteLine("Tripling 5 : {0}", Tripling(i));
            Console.WriteLine("Tripling 3.1 : {0}", Tripling(f));
        }

        public static int Tripling(int x)
        {
            return x*3;
        }

        public static float Tripling(float x)
        {
            return x*3;
        }
    }
}
