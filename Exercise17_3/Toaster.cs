using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_3
{
    class Toaster
    {
        public void subscribe(CountDownClock theClock)
        {
            theClock.TimesUp += delegate(object CountDownClock, CountDownEventArgs cd)
            {
                Console.WriteLine("Notify: {0}", cd.ToString());
            };
        }
    }
}
