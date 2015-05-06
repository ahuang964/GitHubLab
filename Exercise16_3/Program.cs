using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_3
{
    class Program
    {
        public void Run()
        {
            try
            {
                List<Cat> cats = new List<Cat>();
                cats.Add(new Cat(1));
                cats.Add(new Cat(2));
                for (int i = 0; i < 3; i++)
                {
                    cats[i].Age = i + 1;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException has been caught: \n" + e.Message);
            }
            catch
            {
                Console.WriteLine("Unknown expcetion caught");
            }
            finally
            {
                Console.WriteLine("i don't know what deallocating is.");
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
