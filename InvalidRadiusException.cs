using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab5
{
    class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        {
            Console.WriteLine("Invalid radius. Radius must be greater than zero.");
        }

        public InvalidRadiusException(double radius)
        {
            Console.WriteLine($"Invalid radius: {radius}. Radius must be greater than zero.");
        }
    }

}
