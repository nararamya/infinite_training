using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class program21
    {
        static string swapping(string str)
        {
            if (str.Length <= 1)
                return str;
           return  str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];

        }
        static void Main()
        {
            Console.WriteLine("Enter the input1:");
            string input1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the input2:");
            string input2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the input3:");
            string input3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("-----After Swapping-----");
            Console.WriteLine(swapping(input1));
            Console.WriteLine(swapping(input2));
            Console.WriteLine(swapping(input3));
            Console.Read();
        }
    }
}
