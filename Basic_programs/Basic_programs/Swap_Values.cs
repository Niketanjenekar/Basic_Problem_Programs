using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Swap_Values
    {
        public void Values_Swapped(int fVal, int sVal)
        {
            Console.WriteLine("Before Swapping the Value V1 = "+ fVal+ " and V2 = "+ sVal);

            int temp = sVal;

            sVal = fVal;
            
            fVal = temp;

            Console.WriteLine("After Swapping the Value V1 = " + fVal + " and V2 = " + sVal);
        }
    }
}
