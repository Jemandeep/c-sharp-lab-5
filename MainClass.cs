using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle();
                circle1.SetRadius(6);
                Console.WriteLine(circle1);

                Circle circle2 = new Circle();
                circle2.SetRadius(-1);

                Circle circle3 = new Circle();
                circle3.SetRadius(0);
            }
            catch (InvalidRadiusException ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
    }
}
