using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class prog2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input operation:");
            char operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine(first + second);
                    break;
                case '-':
                    Console.WriteLine(first - second);
                    break;

                case '/':
                    Console.WriteLine(first / second);
                    break;
                case '*':
                    Console.WriteLine(first * second);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;


            }
            Console.Read();
        }
    }
}
