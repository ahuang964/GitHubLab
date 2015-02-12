using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalPhone dPhone = new DigitalPhone();
            TalkingPhone tPhone = new TalkingPhone();
            DigitalCellPhone cellPhone = new DigitalCellPhone();
            dPhone.Ring();
            tPhone.Ring();
            dPhone.VoiceMail();
            cellPhone.VoiceMail();
            Console.ReadKey();
        }
    }
}
