using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Saledetails
    {
        protected static int Salesno;
        protected static int Productno;
        protected static int Price;
        protected static DateTime dateofsale;
        protected static int Qty;
        protected static double TotalAmount;

        public Saledetails(int Salesnum, int Productnum, int price, DateTime date, int qty)
        {
            Salesno = Salesnum;
            Productno = Productnum;
            Price = price;
            dateofsale = date;
            Qty = qty;

        }
        public void sales(int Qty, int price)
        {

            TotalAmount = Qty * price;

        }

    }
    class Show : Saledetails
    {
        public Show(int Salesnum, int Productnum, int price, DateTime date, int qty)
            : base(Salesnum, Productnum, price, date, qty)
        {


        }
        static void showdata()
        {

            Console.WriteLine("sales number : {0}", Salesno);
            Console.WriteLine("product number : {0}", Productno);
            Console.WriteLine("price : {0}", Price);
            Console.WriteLine("date of sales : {0}", dateofsale);
            Console.WriteLine("quantity: {0}", Qty);
            Console.WriteLine("Total amount :{0}", TotalAmount);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the sales number:");
            int Salesnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product number:");
            int Productnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the dateofsale:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the quantity:");
            int qty = Convert.ToInt32(Console.ReadLine());
            Show S = new Show( Salesnum, Productnum, price, date, qty);
            S.sales(Qty,price);
            Console.WriteLine("Details are below:");
            showdata();
            Console.Read();
        }
    }
}








