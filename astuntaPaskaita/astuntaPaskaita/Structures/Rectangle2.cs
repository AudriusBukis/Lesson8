using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    internal struct Rectangle2
    {
        public double TopLeftX { get; private set; }
        public double TopLeftY { get; private set; }

        public double BottomRightX { get; private set; }
        public double BottomRightY { get; private set; }

        
        

        public Rectangle2(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY) : this()
        {
            TopLeftX = topLeftX;
            TopLeftY = topLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bottomRightY;
            
        }

        public bool CheckPoint(double xCoordinate, double yCoordinate)
        {
            if (xCoordinate < TopLeftX &&
                xCoordinate > BottomRightX &&
                yCoordinate < BottomRightY &&
                yCoordinate > TopLeftY)
            {
                
                return true;
            }
            return false;
        }

    }
}
