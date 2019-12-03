using System;

namespace ShapeSquare
{
    public class Circle : iShape
    {
        readonly double radius;
     

       public Circle(double r)
        {
            radius = r;
        }
        public double ShapeSquare()
        {
            double square = Math.Pow(radius, 2) * Math.PI;
            return square;
        }
    }
}
