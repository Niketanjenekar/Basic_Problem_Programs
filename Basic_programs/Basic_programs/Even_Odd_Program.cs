using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Even_Odd_Program
    {
        public void Even_Odd(int dig)
        {
            Console.WriteLine("To Check Weather The Number is EVEN or Odd");

            if (dig % 2 == 0)
            {
                Console.WriteLine("Thw Number is EVEN");
            }
            else
            {
                Console.WriteLine("The Number is ODD");
            }
        }
    }
}
