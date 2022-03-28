using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    class SwitchDemo
    {
        static void Main()
        {
            int num1, num2;
            int ch;
            Console.WriteLine("Enter value of num1");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter value of num2");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter choice");
            ch = Convert.ToInt16(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2}");
                    break;
                case 5:
                    Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invlid choice");
                    break;
            }
        }
    }
}