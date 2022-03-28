using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    class Functions
    {
        static void Main()
        {
            //int num1 = 10, num2 = 20;
            int num1, num2;
            
            Console.WriteLine("Enter value of num1");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of num2");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");

            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");

            Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");

            Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");

            Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
            // Operators 
            // Which acts upon operands

            // 1. Arithmatical > + / * / %
            // 2.Assignment  = += -= *= /= %=
            //3. RElational / Comparison > >= < <= == !=
            //4. Logical && || !



        }
    }
}