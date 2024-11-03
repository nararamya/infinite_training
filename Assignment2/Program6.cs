using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program6
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array:");
            size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("array1 elements are:");
            Array.ForEach(a, Console.WriteLine);

            int[] b = new int[size];
            for(int j=0;j<a.Length; j++)
            {
                b[j] = a[j];
            }

           
            Console.WriteLine("array2 elements are:");
            Array.ForEach(b, Console.WriteLine);


            Console.Read();


        }
    }
}

