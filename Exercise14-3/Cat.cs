using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_3
{
    public class Cat:Animal
    {
        public Cat(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Speak()
        {
            Console.WriteLine("MEOW");
            Console.WriteLine(this.ToString());
        }

        public override void Move()
        {
            Console.WriteLine("I Move silently.");
        }

        public override string ToString()
        {
            string msg = string.Format("I am a cat. \nMy name is: {0} and I  weight {1}", name, weight.ToString());
            return msg;
        }
    }
}
