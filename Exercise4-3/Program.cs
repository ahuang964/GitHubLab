using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_3
{
    class Program
    {
        const int maximum = 300;
        const int minimum = 100;

        enum Family
        {
            Abby = 135,
            Bob = 175,
            Chairlie = 55,
            Dawn = 45
        }
        
        static void Main(string[] args)
        {

            rideSafe(Family.Abby, Family.Bob);
            rideSafe(Family.Bob, Family.Chairlie);
            rideSafe(Family.Chairlie, Family.Dawn);
        }

        private static void rideSafe(Family family1, Family family2)
        {
            int a = (int)family1;
            int b = (int) family2;
            int total = a + b;

            Console.WriteLine("{0} and {1} can ride? {2}\n", family1, family2, total > minimum && total < maximum?"True":"False");
        }
    }
}
