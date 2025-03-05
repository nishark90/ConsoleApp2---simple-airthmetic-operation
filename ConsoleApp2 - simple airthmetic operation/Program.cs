using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2___simple_airthmetic_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {// perform simple airthematic operation using switch case//
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("The sum of two numbers is " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("The subraction of two numbers is " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("The multiplication of two numbers is " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("The division of two numbers is " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
