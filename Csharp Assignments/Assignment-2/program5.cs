using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program5
    {
        static void Main(string[] args)
        {

            int Total = 0;
            double average = 0;
            int max = 0;
            int min = int.MaxValue;
            int temp = 0;
            Console.WriteLine("Enter ten marks:");

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                Total += a[i];


                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];

                }
            }

            for (int r = 0; r < a.Length - 1; r++)
            {
                for (int j = r + 1; j < a.Length; j++)
                {
                    if (a[r] > a[j])
                    {
                        temp = a[r];
                        a[r] = a[j];
                        a[j] = temp;

                    }
                    else continue;
                }

            }
            Console.Write("ascending order:");
            
        foreach (int element in a)
        {
          Console.Write(element+" ");
        }
            Console.WriteLine();
            for (int s = 0; s <a.Length-1 ; s++)
            {
                for (int t = s +1; t < a.Length; t++)
                {
                    if (a[s] < a[t])
                    {
                        temp = a[s];
                        a[s] = a[t];
                        a[t] = temp;

                    }
                    else continue;
                }

            }
            Console.Write("descending order:");
            foreach (int elements in a)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine();
             average = (double) Total / a.Length;
            Console.WriteLine("Total:{0}", Total);
            Console.WriteLine("Average : {0}", average);
            Console.WriteLine("Maximum marks:{0}", max);
            Console.WriteLine("Minimum marks :{0}", min);
           

            Console.ReadLine();
        }
    
    }
}
