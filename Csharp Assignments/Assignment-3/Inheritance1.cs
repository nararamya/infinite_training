using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Account
    {
        public int Account_No;
        public string Customer_Name;
        public string Account_Type;
        public string Transaction_Type;
        public int amount;
        public int balance;

        public Account(int account_no, string customer_name, string account_type)
        {
            Account_No = account_no;
            Customer_Name = customer_name;
            Account_Type = account_type;
        }
        public void Set_Data(string transtype, int amoun, int balan)
        {
            Transaction_Type = transtype;
            amount = amoun;
            balance = balan;
        }
    }
    internal class Balanceamount : Account
    {
        public Balanceamount(int account_no, string customer_name, string account_type) : base(account_no, customer_name, account_type)
        {

        }
        public void Credit(int amount)
        {
            balance = balance + amount;
        }
        public void Debit(int amount)
        {
            balance = balance - amount;
        }
        public void Update_Balance(string transac_type)
        {
            if (transac_type == "d" || transac_type == "D")
            {
                Credit(amount);
            }
            else if (transac_type == "w" || transac_type == "W")
            {
                Debit(amount);
            }
        }
        public void Showdata()
        {
            Console.WriteLine($"Account Number : {Account_No}");
            Console.WriteLine($"Customer Name : {Customer_Name}");
            Console.WriteLine($"Account Type : {Account_Type}");
            Console.WriteLine($"Transaction Type : {Transaction_Type}");
            Console.WriteLine($"Amount : {amount}");
            Console.WriteLine($"Balance : {balance}");
        }
    }
    class Inheritance1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the account number : ");
            int acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name : ");
            string customer_name = Console.ReadLine();
            Console.WriteLine("Enter the account type : ");
            string acc_type = Console.ReadLine();


            Balanceamount res = new Balanceamount(acc_no, customer_name, acc_type);


            Console.WriteLine("Enter the transaction type : ");
            string transtype = Console.ReadLine();
            Console.WriteLine("Enter the amount : ");
            int amoun= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the balance : ");
            int balan = Convert.ToInt32(Console.ReadLine());

            res.Set_Data(transtype, amoun, balan);
            res.Update_Balance(transtype);

            Console.WriteLine("Customer details:");
            res.Showdata();

            Console.Read();
        }
    }
}