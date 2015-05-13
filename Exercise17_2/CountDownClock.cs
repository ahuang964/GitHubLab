using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise17_2
{
    class CountDownClock
    {
        private int seconds;
        private string message;
        private int nowSecond;

        public CountDownClock(string msg, int s)
        {
            message = msg;
            seconds = s;
        }

        public delegate void CountDownHandler(object CountDownClock, CountDownEventArgs countDownEvent);

        public event CountDownHandler TimesUp;

        public void Run()
        {
            for (; seconds >= 0; )
            {
                Thread.Sleep(100);
                System.DateTime dt = System.DateTime.Now;
                if (dt.Second != nowSecond)
                {
                    Console.WriteLine("Now reading: {0} s", seconds);
                    seconds--;
                    nowSecond = dt.Second;
                }
            }

            CountDownEventArgs timsupEvent = new CountDownEventArgs(message);

            if (TimesUp != null)
            {
                TimesUp(this, timsupEvent);
            }
        }
    }
}
