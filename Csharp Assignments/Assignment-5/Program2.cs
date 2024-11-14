using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5
{
    class Write
    {
        static void Main(string[] args)
        {

            StreamReaderWriter srw = new StreamReaderWriter();
            srw.WriteData();

            Console.ReadKey();
        }




        class StreamReaderWriter
        {
            public void WriteData()
            {

                Console.WriteLine("Enter the size of array");
                int size = int.Parse(Console.ReadLine());
                String[] a = new String[size];
                
                FileStream s = new FileStream("file.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(s);


                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(a[i]);
                    Console.WriteLine(" Enter string:{0}", a[i]);
                    string sr = Console.ReadLine();
                    sw.WriteLine(sr);

                }



                sw.Flush();
                sw.Close();
                s.Close();
            }

        }
    }
}
    

