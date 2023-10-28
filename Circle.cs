using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab5
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { SetRadius(value); }
        }

        public void SetRadius(double value)
        {
            if (value > 0)
            {
                radius = value;
            }
            else
            {
                throw new InvalidRadiusException(value);
            }
        }

        public override string ToString()
        {
            return $"Circle with radius: {radius}";
        }
    }
}
