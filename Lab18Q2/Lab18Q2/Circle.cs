using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Q2
{
    class Circle
    {
        private double _radius;
        private double _height;

        public double Radius
        {
         
            set
            {
                _radius = value;
            }
        }

        public double Height
        {
            
            set
            {
                _height = value;
            }
        }

        public double SurfaceAreaCylinder()
        {
            double area;
            return area = (2 * Math.PI *_radius * _height) + (2 * Math.PI * Math.Pow(_radius,2));
        }
    }
}
