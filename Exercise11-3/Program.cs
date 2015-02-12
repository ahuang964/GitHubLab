using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalPhone dPhone = new DigitalPhone();
            TalkingPhone tPhone = new TalkingPhone();
            dPhone.Ring();
            tPhone.Ring();
            Console.ReadKey();
        }
    }
}
