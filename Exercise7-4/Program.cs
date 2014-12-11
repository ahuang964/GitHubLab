using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point onePoint = new Point(1,1);
            Square oneSquare = new Square(onePoint, 10);
            oneSquare.Output();
        }
    }
}
