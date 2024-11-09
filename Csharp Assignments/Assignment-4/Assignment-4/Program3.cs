using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Doctor
    {
        private int _RegNo;
        private string _Name;
        private int _Feescharged;

        public int regno
        {
            get
            {
                return _RegNo;
            }
            set
            {
                _RegNo = value;
            }
        }
        public string name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public int feescharged
        {
            get
            {
                return _Feescharged;
            }
            set
            {
                _Feescharged = value;
            }
        }
    }
        class Books
        {
            public string BookName;
            public string AuthorName;

            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;

            }
            public string bookName
            {
                get
                {
                    return BookName;
                }
                set
                {
                    BookName = value;
                }
            }
            public string authorName
            {
                get
                {
                    return AuthorName;
                }
                set
                {
                    AuthorName = value;
                }
            }
            public void Display()
            {
            
                Console.WriteLine("book name:" + bookName);

                Console.WriteLine("author name:" + authorName);


            }

        }
        class BookShelf
        {
            Books[] bb = new Books[5];

            public Books this[int i]
            {
                get
                {
                    return bb[i];
                }
                set { bb[i] = value; }
            }
        }
    
        class Properties
            {
              static void Main()
             {
           
                    Console.WriteLine("Enter regno:");
                    int regno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter  name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter feescharged:");
                    int feescharged =int.Parse( Console.ReadLine());
                    Doctor doc = new Doctor();
                    doc.regno = regno;
                    doc.name = name;
                    doc.feescharged =feescharged;

           
                    Console.WriteLine("The regno is {0}", doc.regno);
                    Console.WriteLine("The name is {0}", doc.name);
                    Console.WriteLine("The feescharged is {0}", doc.feescharged);


                BookShelf bs = new BookShelf();

                   for(int i=0;i<5;i++)
                {
                    Console.WriteLine("Enter the bookname:", i + 1);
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter author name:",i+1);
                    string authorName = Console.ReadLine();
                    bs[i] = new Books(bookName,authorName);
                }
                for (int i = 0; i < 5; i++)
                {
                    bs[i].Display();
                }



                Console.Read();

             }
        }
     }




