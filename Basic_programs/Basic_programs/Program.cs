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
            Console.WriteLine("7. Number is even or Odd");
            Console.WriteLine("8. Number is Positive or Not");
            Console.WriteLine("9. Largest of two Numbers");
            Console.WriteLine("10. Reverse a number");
            Console.WriteLine("11. Reverse a Number and check Weather it's a Palindrome or Not");

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
                case 7:
                    //Seventh Problem
                    Console.WriteLine("Please enter the Number to Check Weather the Number is EVEN or ODD");
                    int dig = Convert.ToInt32(Console.ReadLine());
                    Even_Odd_Program even_Odd_Program = new Even_Odd_Program();
                    even_Odd_Program.Even_Odd(dig);
                    break;
                case 8:
                    
                    Console.WriteLine("Please enter the Number to Check Weather the Number is Positive or Not");
                    int digit = Convert.ToInt32(Console.ReadLine());
                    Positive_or_Not positive_or_not  = new Positive_or_Not();
                    positive_or_not.Positive_Or(digit);
                    break;
                case 9:
                    Console.WriteLine("Please Enter the First Number to Check the Largest Number");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter the Second Number to Check the Largest Number");
                    int numTwo = Convert.ToInt32(Console.ReadLine());
                    Largest_Number largest_Number = new Largest_Number();
                    largest_Number.Largest_or_Not(numOne, numTwo);
                    break;
                case 10:
                    Console.WriteLine("Please Enter the Number to Reverse It");
                    int numThree = Convert.ToInt32(Console.ReadLine());
                    Reverse_a_Number reverse_A_Number = new Reverse_a_Number();
                    reverse_A_Number.Reverse_Number(numThree);
                    break;
                case 11:
                    Console.WriteLine("Please Enter the Number To Reverse and Check Palindrome");
                    int numFour = Convert.ToInt32(Console.ReadLine());
                    Palindrome_or_Not palindrome_Or_Not = new Palindrome_or_Not();
                    palindrome_Or_Not.Palindrome(numFour);
                    break;
            }         
            
            Console.ReadLine();
        }
    }
}
