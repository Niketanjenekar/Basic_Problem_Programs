using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Palindrome_or_Not
    {   public void Palindrome(int numFour)
        {
            int reversedNumber = 0;
            int temp = numFour;
            Console.WriteLine("Check if The Reversed Number is Palindrome or Not");

            while (numFour > 0)
            {
                int rem = numFour % 10;
                reversedNumber = reversedNumber * 10 + rem;
                numFour /= 10;
            }
            Console.WriteLine("The reversed Number is " + reversedNumber);

            if (reversedNumber == temp)
            {
                Console.WriteLine("The Reversed Number is a Palindrome");
            }
            else
            {
                Console.WriteLine("The Reversed Number is Not a Palindrome");
            }
        }
    }
}
