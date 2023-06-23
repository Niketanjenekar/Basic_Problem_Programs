using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Positive_or_Not
    {
        public void Positive_Or(int digit)
        {
            Console.WriteLine("To Check Weather the Number is Positive Or Not");
            if (digit > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else
            {
                Console.WriteLine("The number is Negetive");
            }
        }
    }
}
