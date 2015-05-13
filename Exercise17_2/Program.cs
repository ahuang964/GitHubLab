using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_2
{
    class Program
    {
        public void Run()
        {
            CountDownClock toasterCountDown = new CountDownClock("Toasts are ready to serve", 30);
            
            Toaster toaster = new Toaster();
            ToasterChef chef = new ToasterChef();

            toaster.subscribe(toasterCountDown);
            chef.subscribe(toasterCountDown);

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
