using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_1
{
    class Program
    {
        public void Run()
        {
            Animal[] animals = new Animal[5];
            for (int i = 0; i < 5; i++)
            {
                if (i%2 == 0)
                {
                    animals[i] = new Dog("puppy"+i.ToString(), i*20);
                }
                else
                {
                    animals[i] = new Cat("pussycat"+i.ToString(), i*2);
                }
            }

            foreach (Animal animal in animals)
            {
                animal.Speak();
                animal.Move();
            }
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
