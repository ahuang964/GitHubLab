using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_4
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

        //static method to get comparer object
        public static AnimalComparer GetComparer()
        {
            return new Animal.AnimalComparer();
        }

        //Special CompareTo to be called by custom comparer
        public int CompareTo(Animal rhs, Animal.AnimalComparer.ComparisonType which)
        {
            switch (which)
            {
                case Animal.AnimalComparer.ComparisonType.Weight:
                    return this.weight.CompareTo(rhs.weight);
                case Animal.AnimalComparer.ComparisonType.Name:
                    return this.name.CompareTo(rhs.name);
            }
            return 0;
        }

        //nested class which implements custom comparer
        public class AnimalComparer : IComparer<Animal>
        {
            //private state variable
            private Animal.AnimalComparer.ComparisonType whichComparison;

            //enumeration of comparison types
            public enum ComparisonType
            {
                Weight,
                Name
            };

            //must imlement
            public int Compare(Animal lhs, Animal rhs)
            {
                return lhs.CompareTo(rhs, whichComparison);
            }

            public Animal.AnimalComparer.ComparisonType WhichComparisonType
            {
                get { return whichComparison; }
                set { whichComparison = value; }
            }
        }
    }
}
