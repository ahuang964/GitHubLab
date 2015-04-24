using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_1
{
    public class Dog:Animal
    {
        public Dog(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Speak()
        {
            Console.WriteLine("RUFF");
            Console.WriteLine(this.ToString());
        }

        public override void Move()
        {
            Console.WriteLine("I Move with wiggly tail.");
        }

        public override string ToString()
        {
            string msg = string.Format("I am a dog. \nMy name is: {0} and I  weight {1}", name, weight.ToString());
            return msg;
        }
    }
}
