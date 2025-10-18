using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        public double Area;
        public double Radius;
        public double Circumference;
        public double Volume;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetArea()
        {
            Area = Radius * Radius * Math.PI;
            return Area;
        }
        public double GetCircumference()
        {
            Circumference = (Radius * 2) * Math.PI;
            return Circumference;
        }
        public double GetVolume()
        {
            Volume = (4.0/3.0) * Math.PI * Math.Pow(Radius, 3);
            return Volume;
        }

        public void PrintOne()
        {
            Console.WriteLine(Area);
        }
        public void PrintTwo()
        {
            Console.WriteLine(Circumference);
        }
        public void PrintThree()
        {
            Console.WriteLine(Volume);
        }
    }
}
