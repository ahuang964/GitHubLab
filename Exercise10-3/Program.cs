using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] awards1 = {"award1", "award2"};
            string[] awards2 = { "award3", "award4", "award5"};
            string[] awards3 = { "award6", "award7", "award8", "award9" };

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(26, "Milo", awards1);
            dogs[1] = new Dog(10, "Frisky", awards2);
            dogs[2] = new Dog(50, "Laika", awards3);

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Output();
            }
        }
    }
}
