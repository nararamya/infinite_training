using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class program3
    {
        static int largestnumber(int a,int b,int c)
        {
            return Math.Max(a, Math.Max(b, c));

        }
        static void Main()
        {
           
            Console.WriteLine("Enter the three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the three numbers:");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter the three numbers:");
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("------------Largest numbers are:------------");

            Console.WriteLine(largestnumber(a, b, c));
            Console.WriteLine(largestnumber(d, e, f));
            Console.WriteLine(largestnumber(g, h, s));
            Console.Read();


        }
    }
}
