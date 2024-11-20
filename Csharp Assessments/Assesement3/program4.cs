using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesement3
{
    public delegate int CalculatorOPeration(int a, int b);
    class program4
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first integer:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorOPeration addoperation = new CalculatorOPeration(Add);
            CalculatorOPeration suboperation = new CalculatorOPeration(Subtract);
            CalculatorOPeration muloperation = new CalculatorOPeration(Multiply);

            int additionResult = addoperation(num1, num2);
            Console.WriteLine($"Addition:{num1}+{num2}={additionResult}");

            int subtractionResult = suboperation(num1, num2);
            Console.WriteLine($"Subtraction:{num1}-{num2}={subtractionResult}");

            int MultiplicationResult = muloperation(num1, num2);
            Console.WriteLine($"Multiplication:{num1}*{num2}={MultiplicationResult}");


            Console.Read();

        }
    }

}
