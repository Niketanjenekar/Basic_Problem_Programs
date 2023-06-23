using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Area_Of_Circle
    {
        public void Area(double radius)
        {
            double area = Math.PI * radius * radius;

            Console.WriteLine("The Area Of the Circle is " + area);
        }
    }
}
