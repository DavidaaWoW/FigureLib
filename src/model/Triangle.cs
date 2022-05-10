using System;

namespace TestLib
{
    public class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;
        private double p;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            p = (side1+side2+side3) / 2;
        }

        public double getSquare()
        {
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }

        public bool isRigth()
        {
            if(Math.Pow(side1,2) + Math.Pow(side2, 2) == Math.Pow(side3,2) || Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2) || Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2))
            {
                return true;
            }
            return false;
        }
    }
}
