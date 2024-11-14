using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
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
        static void Main(string[] args)
        {
            BookShelf bs = new BookShelf();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the bookname:", i + 1);
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter author name:", i + 1);
                string authorName = Console.ReadLine();
                bs[i] = new Books(bookName, authorName);
            }
            for (int i = 0; i < 5; i++)
            {
                bs[i].Display();
            }



            Console.Read();

        }
    }
}

        


