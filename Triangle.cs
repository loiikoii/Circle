using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Triangle
    {
        public double Base;
        public double Height;
        public double TArea;

        public Triangle(double _base, double height)
        {
            Base = _base;
            Height = height;
        }
        public double GetArea()
        {
            TArea = (Base * Height) / 2;
            return TArea;
        }
        public void TPrintOne()
        {
            Console.WriteLine(TArea);
        }
    }
}
