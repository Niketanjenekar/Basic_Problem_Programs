using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Reverse_a_Number
    {
        public void Reverse_Number(int numThree)
        {
            int reverseNumber = 0;
            Console.WriteLine("To Reverse the Number");
            
            while(numThree > 0)
            {
                int rem = numThree % 10;
                reverseNumber = reverseNumber * 10 + rem;
                numThree /= 10;
            }
            Console.WriteLine("The reversed Number is " +  reverseNumber);
        }
    }
}
