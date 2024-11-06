using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Program4
    {
        static int counting(string s,char letter)
        {
            int i = 0;
            foreach(char c in s.ToLower())
            {
                if (c == char.ToLower(letter))
                    i++;
            }
            return i;
        }
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the letter:");
            char letter = Console.ReadLine()[0];

            Console.WriteLine($"The no. of occurrences of {letter} in a given string is {counting( s,letter)} times");
            Console.Read();
        }
    }
}
