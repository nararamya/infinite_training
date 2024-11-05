using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Strings
    {
        static void Main(string[] args)
        {
            string word, word1, word2;

            Console.WriteLine("Enter the word:");
            word = Convert.ToString(Console.ReadLine());
            int Len = word.Length;

            Console.WriteLine("The length of {0} is {1}", word, Len);

            Console.WriteLine("reverse of word is {0}", string.Join("", word.Reverse()));
            Console.WriteLine("Enter the word1:");
            word1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the word2:");
            word2 = Convert.ToString(Console.ReadLine());
            if (word1 == word2)
            {
                Console.WriteLine("Strings are same");

            }
            else
            {
                Console.WriteLine("Strings are different");
            }

            Console.Read();

        }
    }
    
}
