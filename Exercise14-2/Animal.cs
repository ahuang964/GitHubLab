using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_2
{
    public abstract class Animal: IComparable<Animal>
    {
        public int weight { get; set; }
        public string name { get; set; }
        public abstract void Speak();
        public abstract void Move();
        public abstract string ToString();

        public int CompareTo(Animal rhs)
        {
            return this.weight.CompareTo(rhs.weight);
        }
    }
}
