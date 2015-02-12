using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone ePhone = new ElectronicPhone();
            ePhone.Ring();
            Console.ReadKey();
        }
    }
}
