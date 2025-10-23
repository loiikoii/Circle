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
            Radius = radius;
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
            Console.WriteLine($"Cirkeln med radien av {Radius}cm har en area av {Area} cm²");
        }
        public void PrintTwo()
        {
            Console.WriteLine($"Cirkeln har en omkrets av {Circumference} cm");
        }
        public void PrintThree()
        {
            Console.WriteLine($"Klotet har en volym på {Volume} cm³");
        }
    }
}
