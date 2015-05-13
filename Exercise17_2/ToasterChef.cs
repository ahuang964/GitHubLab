using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_2
{
    class ToasterChef
    {
        public void subscribe(CountDownClock theClock)
        {
            theClock.TimesUp += new CountDownClock.CountDownHandler(toasterTimesUp);
        }

        public void toasterTimesUp(object CountDownClock, CountDownEventArgs cd)
        {
            Console.WriteLine("Chef go get your toast.");
        }
    }
}
