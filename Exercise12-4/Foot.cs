using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_4
{
    class Foot
    {
        public double length { get; set; }

        public Foot(double num)
        {
            length = num;
        }

        public override string ToString()
        {
            string str = string.Format("Length: {0} Foot", length);
            return str;
        }

        public static implicit operator Foot(Meter f)
        {
            return new Foot(f.length*3.28084);
        }
    }
}
