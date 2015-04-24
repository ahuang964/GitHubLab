using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_2
{
    class Program
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(100);
                if (num%2 == 0)
                {
                    Animal newAnimal = new Dog("Puppy"+i, num);
                    animals.Add(newAnimal);
                }
                else
                {
                    Animal newAnimal = new Cat("Pussy"+i, num/2);
                    animals.Add(newAnimal);
                }   
            }

            foreach (Animal animal in animals)
            {
                animal.Speak();
            }

            //sort the shit
            animals.Sort();
            Console.WriteLine("\nNow Sorting.......\n");
            foreach (Animal animal in animals)
            {
                animal.Speak();
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
