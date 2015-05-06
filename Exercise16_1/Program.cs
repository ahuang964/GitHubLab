using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_1
{
    class Program
    {
        public void Run()
        {
            int[] simple = new int[3];
            simple[0] = 0;
            simple[1] = 1;
            simple[2] = 2;
            string answer;
            try
            {
                do
                {
                    Console.WriteLine("Which array element you wants to see?");
                    answer = Console.ReadLine();
                    int answerInt = Int32.Parse(answer);
                    Console.WriteLine("You wanted to see: {0}", simple[answerInt]);
                    Console.WriteLine("Continue?");
                    answer = Console.ReadLine();
                } while (answer == "y");
            }
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("You picked a bad number.");
            //}
            catch
            {
                Console.WriteLine("Unknown expcetion caught");
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
