using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5
{
    class Lines
    {
        static void Main(string[] args)
        {
           StreamReaderWriter srw = new StreamReaderWriter();
         
            srw.ReadData();
            Console.ReadKey();
        }




        class StreamReaderWriter
        {
            
            public void ReadData()
            {
                FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);
                int count = 0;
                string st = sr.ReadLine();

                while (st != null)
                {
                    Console.WriteLine("{0} ", st);
                    st = sr.ReadLine();
                    count++;
                }
                Console.WriteLine("The number of lines is {0}", count);

                sr.Close();
                fs.Close();
            }
        }
    }
}
    



