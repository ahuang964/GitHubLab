using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_3
{
    class Program
    {
        public void Run()
        {
            Stack<Animal> animalsStack = new Stack<Animal>();
            Queue<Animal> animalsQueue = new Queue<Animal>();
            Random rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(100);
                if (num % 2 == 0)
                {
                    Animal newAnimal = new Dog("Puppy" + i, num);
                    animalsStack.Push(newAnimal);
                    animalsQueue.Enqueue(newAnimal);
                }
                else
                {
                    Animal newAnimal = new Cat("Pussy" + i, num / 2);
                    animalsStack.Push(newAnimal);
                    animalsQueue.Enqueue(newAnimal);
                }
            }

            //round1
            PrintValues(animalsQueue);
            PrintValues(animalsStack);
            Console.WriteLine("\n(Dequeue)\t{0}", animalsQueue.Dequeue().ToString());
            Console.WriteLine("(Pop)\t{0}\n", animalsStack.Pop().ToString());
            //round2
            PrintValues(animalsQueue);
            PrintValues(animalsStack);
            Console.WriteLine("\n(Dequeue)\t{0}", animalsQueue.Dequeue().ToString());
            Console.WriteLine("(Pop)\t{0}\n", animalsStack.Pop().ToString());
            //round3
            PrintValues(animalsQueue);
            PrintValues(animalsStack);
            Console.WriteLine("\n(Dequeue)\t{0}", animalsQueue.Dequeue().ToString());
            Console.WriteLine("(Pop)\t{0}\n", animalsStack.Pop().ToString());
            //round4
            PrintValues(animalsQueue);
            PrintValues(animalsStack);
        }

        public static void PrintValues(IEnumerable<Animal> myQueue)
        {
            IEnumerator<Animal> myEnumerator = myQueue.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine("{0} ", myEnumerator.Current.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
