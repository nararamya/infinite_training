using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Program
    {
        static string removed(string remove,int position)
        {
            return remove.Substring(0, position) + remove.Substring(position + 1);

        }
        static void Main()
        {
            Console.WriteLine("Enter the string1:");
            string string1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the string2:");
            string string2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the string3:");
            string string3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the position:");
            int pos1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position:");
            int pos2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position:");
            int pos3 = int.Parse(Console.ReadLine());

            Console.WriteLine("After removing the character at a given position in the string");

            Console.WriteLine(removed(string1, pos1));
            Console.WriteLine(removed(string2, pos2));
            Console.WriteLine(removed(string3, pos3));

            Console.Read();
        }
    }
}
