using System;

namespace Assignment3_S29927
{
    public class Rectangle : IShape
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculateVolume()
        {
            return 0;
        }
    }
}
