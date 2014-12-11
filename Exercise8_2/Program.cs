using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("white");

            Console.WriteLine("My dog has color {0}", myDog.Color);
            Console.WriteLine("Please enter dog's weight:");
            string weight = Console.ReadLine();
            myDog.Weight = Convert.ToDouble(weight);
            Console.WriteLine("My dog is weighted {0}", myDog.Weight);
        }
    }
}
