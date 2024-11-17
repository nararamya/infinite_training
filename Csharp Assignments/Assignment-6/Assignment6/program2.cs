using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class program2
    {
        static void Main(string[] args)
        {
            List<string> sg = new List<string>();
            Console.WriteLine("Enter the number of words in the list : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Enter the {0} word ", i);
                string name = Console.ReadLine();
                sg.Add(name);
            }
            var names = from v in sg
                        where v.StartsWith("a") && v.EndsWith("m")
                        select v;
            Console.WriteLine(" words starting with letter 'a' and ending with letter 'm'");
            foreach (var i in names)
            {
                Console.WriteLine(i + " ");
            }
            Console.Read();
        }
    }
}
