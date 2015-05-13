using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_4
{
    class Toaster
    {
        public void subscribe(CountDownClock theClock)
        {
            theClock.TimesUp +=
                (aClock, cd) =>
                {
                    Console.WriteLine("Notify: {0}", cd.ToString());
                };
        }
    }
}
