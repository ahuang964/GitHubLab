using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_4
{
    class TalkingPhone:Telephone
    {
        public TalkingPhone()
        {
            phoneType = "Talking.";
        }

        public override void Ring()
        {
            Console.WriteLine("Talking the shit outta " + phoneType);
        }
    }
}
