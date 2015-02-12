using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_2
{
    class ElectronicPhone:Telephone
    {
        public ElectronicPhone()
        {
            phoneType = "Digital.";
        }

        public override void Ring()
        {
            Console.WriteLine("Digitally Beep the " + phoneType);
        }
    }
}
