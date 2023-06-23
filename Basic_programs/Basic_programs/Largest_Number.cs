using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Largest_Number
    {
        public void Largest_or_Not(int numOne, int numTwo)
        {
            Console.WriteLine("To Check Which of the Number is Largest");

            if (numOne > numTwo)
            {
                Console.WriteLine(numOne + " is the Largest Number");
            }
            else
            {
                Console.WriteLine(numTwo + " is the Largest Number");
            }
        }
    }
}
