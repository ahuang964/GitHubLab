using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_1
{
    class Program
    {
        public void Run()
        {
            CountDownClock toasterCountDown = new CountDownClock("Toaster ready to eat", 5);
            ToasterNotify note = new ToasterNotify();

            note.subscribe(toasterCountDown);
            toasterCountDown.Run();
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
