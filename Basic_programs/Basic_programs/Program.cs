using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************** Basic Programs **************");

            Console.WriteLine("Please choose the Program you want to Execute");

            Console.WriteLine("1. Size of Data-Types");
            Console.WriteLine("2. Convert days to Years, Weeks, and Month");
            Console.WriteLine("3. Print ASCII Values");
            Console.WriteLine("4. Calculate Area Of Circle");
            Console.WriteLine("5. Swap Values Of Two Variables");
            Console.WriteLine("6. All Arithematic Operations");

            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    //First Problem
                    Size_Of_DataTypes sizes = new Size_Of_DataTypes();
                    sizes.Size_Of_Data();
                   break;
                case 2:
                    //Second Problem
                    Console.WriteLine("Please Enter the Number Of Days");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Days_Conversion days_Conversion = new Days_Conversion();
                    days_Conversion.Days_Convert(num);
                   break;
                case 3:
                    //Third Problem
                    Printing_Values values = new Printing_Values();
                    values.Print();
                   break;
                case 4:
                    //Fourth Problem
                    Console.WriteLine("Calculating Area Of Circle");
                    Console.WriteLine("Enter the Radius of the Circle");
                    double radius = double.Parse(Console.ReadLine());
                    Area_Of_Circle circleArea = new Area_Of_Circle();
                    circleArea.Area(radius);
                   break;
                case 5:
                    //Fifth Problem
                    Console.WriteLine("Swapping Values");
                    Console.WriteLine("Please enter the First Value");
                    int fVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the Second Value");
                    int sVal = Convert.ToInt32(Console.ReadLine());
                    Swap_Values swap = new Swap_Values();
                    swap.Values_Swapped(fVal, sVal);
                   break;
                case 6:
                    //Sixth Problem
                    Console.WriteLine("Please Enter the First Value");
                    double fval = double.Parse(Console.ReadLine());
                    Console.WriteLine("Pleasr Enter the Second Value");
                    double sval = double.Parse(Console.ReadLine());
                    Arithematic_Operation arithematic_Operation = new Arithematic_Operation();
                    arithematic_Operation.Operation(fval, sval);
                   break;
            }         
            
            Console.ReadLine();
        }
    }
}
