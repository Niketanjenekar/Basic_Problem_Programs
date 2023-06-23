using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Arithematic_Operation
    {
        public void Operation(double fval, double sval)
        {
            Console.WriteLine("Performing All Arithematic Operation");

            double Sum = fval + sval;
            double Substract = fval - sval;
            double Multiply = fval * sval;
            double Divide = fval / sval;

            Console.WriteLine("Addition of Values is : " + Sum);
            Console.WriteLine("Substraction of Values is : " + Substract);
            Console.WriteLine("Multiplication of Values is : " +  Multiply);
            Console.WriteLine("Division of Values is : "+ Divide);
        }
    }
}
