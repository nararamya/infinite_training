using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int size;

                Console.WriteLine("Enter the size of an array:");
                size = int.Parse(Console.ReadLine());
                int[] a = new int[size];
                Console.WriteLine("Enter the elements of array:");
                for (int i = 0; i < size; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("The squares of numbers are");


                var sno = from int Num in a
                          let Sqrnum = Num * Num
                          where Sqrnum > 20
                          select new { Num, Sqrnum };


                foreach (var s in sno)
                    Console.WriteLine(s);

                Console.ReadLine();
            }
        }

    }


