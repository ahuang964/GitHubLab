using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_2
{
    class Invoice
    {
        private string vendor;
        private double amount;

        public Invoice(string vendor, double amount)
        {
            this.vendor = vendor;
            this.amount = amount;
        }

        public override string ToString()
        {
            string output = string.Format("\nVendor: {0} \nAmount: {1}\n", vendor, amount);
            return output;
        }

        public static Invoice operator+ (Invoice lhs, Invoice rhs)
        {
            if (lhs.vendor == rhs.vendor)
            {
                return new Invoice(lhs.vendor, lhs.amount+rhs.amount);
            }
            else
            {
                return new Invoice("",0);
            }
        }

        public static bool operator ==(Invoice lhs, Invoice rhs)
        {
            if ((lhs.vendor == rhs.vendor) && (lhs.amount == rhs.amount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Invoice lhs, Invoice rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object o)
        {
            return this == (Invoice)o;
        }
    }
}
