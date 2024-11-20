using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assesement3
{
    class program3
    {
        static void Main(string[] args)
        {
            string filepath = "File.txt";
            Console.WriteLine("Enter text to append to the file");
            string textToAppend = Console.ReadLine();

           
                using(StreamWriter writer=new StreamWriter(filepath,true))
                {
                    writer.WriteLine(textToAppend);
                }
               



            Console.WriteLine("Text Appended :");
            Console.WriteLine(File.ReadAllText(filepath));
            Console.Read();
            
        }
    }
}
