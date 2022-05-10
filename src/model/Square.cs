using System;
using System.Collections.Generic;
using System.Text;

namespace TestLib
{
    class Square : Figure
    {
        private double radius;

        public Square(double radius)
        {
            this.radius = radius;
        }
        public double getSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
