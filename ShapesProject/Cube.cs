using System;

namespace Assignment3_S29927
{
    public class Cube : IShape
    {
        private readonly double side;

        public Cube(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        public double CalculateVolume()
        {
            return Math.Pow(side, 3);
        }
    }
}
