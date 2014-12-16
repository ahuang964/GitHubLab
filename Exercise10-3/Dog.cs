using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_3
{
    class Dog
    {
        private int weight { get; set; }
        private string name { get; set; }
        private string[] awards { get; set; }


        public Dog(int weight, string name, string[] awards)
        {
            this.weight = weight;
            this.name = name;
            this.awards = awards;
        }

        public void Output()
        {
            Console.WriteLine("Dog name: {0}; Dog weight: {1} pounds", name, weight);
            Console.WriteLine("Awards won:");
            foreach (string str in awards)
            {
                Console.WriteLine(str);
            }
        }
    }
}
