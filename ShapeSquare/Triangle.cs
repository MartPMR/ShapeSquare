using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSquare
{
    public class Triangle : iShape
    { 
        readonly double a, b, c;
        double p, S;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double ShapeSquare()
        {
            p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        public bool IsoscelesTriangle()
        {
            if (a == b || a == c || b == c)
                return true;
            else
                return false;
        }

    }
}
