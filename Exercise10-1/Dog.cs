using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_1
{
    class Dog
    {
        private int weight { get; set; }
        private string name { get; set; }

        public Dog(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public void Output()
        {
            Console.WriteLine("Dog name: {0}; Dog weight: {1} pounds", name, weight);
        }
    }
}
