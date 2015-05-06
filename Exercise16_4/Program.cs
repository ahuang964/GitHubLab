using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_4
{
    

    class Program
    {
        public void Run()
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat(1));
            cats.Add(new Cat(2));
            cats.Add(new Cat(-3));
            cats.Add(new Cat(4));
            cats.Add(new Cat(5));
            
            CatManager manager = new CatManager();
            manager.cats = cats;
            manager.LookForBadAge();
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
