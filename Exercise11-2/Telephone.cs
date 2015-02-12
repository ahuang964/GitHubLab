using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_2
{
    class Telephone
    {
        protected string phoneType;

        public virtual void Ring()
        {
            Console.WriteLine("Ringing the "+phoneType);
        }
    }
}
