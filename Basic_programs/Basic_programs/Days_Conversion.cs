using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Days_Conversion
    {
        public void Days_Convert(int num)
        {
            Console.WriteLine("Converting Days to Years, Months and Weeks");

            int Days, Years, Weeks, Months;

            Years = (num / 365);
            
            Weeks = (num / 7);

            Months = (num / 30);

            Console.WriteLine("Years : " + Years);
            
            Console.WriteLine("Weeks : " + Weeks);

            Console.WriteLine("Months : " + Months);
        }
    }
}
