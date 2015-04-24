using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_1
{
    public abstract class Animal
    {
        public int weight { get; set; }
        public string name { get; set; }
        public abstract void Speak();
        public abstract void Move();
        public abstract string ToString();
    }
}
