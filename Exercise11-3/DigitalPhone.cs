using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_3
{
    class DigitalPhone:Telephone
    {
        public DigitalPhone()
        {
            phoneType = "Digital.";
        }

        public override void Ring()
        {
            Console.WriteLine("Digitally Beep the " + phoneType);
        }
    }
}
