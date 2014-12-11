using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_4
{
    class Square
    {
        public Point APoint;
        public Point BPoint;
        public Point CPoint;
        public Point DPoint;

        public Square(Point a, int length)
        {
            APoint = new Point(a.X, a.Y);
            BPoint = new Point(APoint.X+length, APoint.Y);
            CPoint = new Point(APoint.X+length, APoint.Y+length);
            DPoint = new Point(APoint.X, APoint.Y+length);
        }

        public void Output()
        {
            Console.WriteLine("APoint ({0}, {1})", APoint.X, APoint.Y);
            Console.WriteLine("BPoint ({0}, {1})", BPoint.X, BPoint.Y);
            Console.WriteLine("CPoint ({0}, {1})", CPoint.X, CPoint.Y);
            Console.WriteLine("DPoint ({0}, {1})", DPoint.X, DPoint.Y);
        }
    }
}
