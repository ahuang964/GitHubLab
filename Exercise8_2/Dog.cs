using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_2
{
    class Dog
    {
        public double Weight { get; set; }
        public string Color { get; set; }

        public Dog(string color)
        {
            Color = color;
        }
    }
}
