using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(26, "Milo");
            dogs[1] = new Dog(10, "Frisky");
            dogs[2] = new Dog(50, "Laika");

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Output();
            }
        }
    }
}
