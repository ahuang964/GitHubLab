using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_4
{
    class Meter
    {
        public double length { get; set; }

        public Meter(double num)
        {
            length = num;
        }

        public override string ToString()
        {
            string str = string.Format("Length: {0} Meter", length);
            return str;
        }

        public static implicit operator Meter(Foot f)
        {
            return new Meter(f.length*0.3048);
        }
    }
}
