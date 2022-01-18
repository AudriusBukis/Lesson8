using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct Point
    {
        public double CoordineteX { get; private set; }
        public double CoordineteY { get; private set; }

        public Point(double coordineteX, double coordineteY)
        {
            CoordineteX = coordineteX;
            CoordineteY = coordineteY;
        }
    }
}
