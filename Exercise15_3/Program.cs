using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15_3
{
    class Program
    {
        public void Run()
        {
            string famousString = "We choose to go to the moon. We choose to go to the moon in this decade and do the other things, not because they are easy, but because they are hard, because that goal will serve to organize and measure the best of our energies and skills, because that challenge is one that we are willing to accept, one we are unwilling to postpone, and one which we intend to win, and the others, too.";
            int counter = 0;

            foreach (string subString in famousString.Split(' '))
            {
                if (subString == "the")
                {
                    counter++;
                }
            }

            Console.WriteLine("The word \"the\" shows up {0} times.", counter);
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
