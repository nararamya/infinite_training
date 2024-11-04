using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program4
    {
        static void Main(string[] args)
        {
            int size;
            int sum = 0;
            double average = 0;
            int max = 0;
            int min = int.MaxValue;
            Console.WriteLine("Enter the size of an array:");
            size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                sum += a[i];


                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];

                }
            }
        

                  average = (double)sum / size;
            
            Console.WriteLine("Average of array is: {0}", average);
            Console.WriteLine("Maximum value in an array is :{0}", max);
            Console.WriteLine("Minimum value in an array is :{0}", min);
            Console.ReadLine();
        }
    }
}
