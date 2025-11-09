using System;

namespace Assignment3_S29927
{
    public class Cylinder : IShape
    {
        private readonly double radius;
        private readonly double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double CalculateArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}
