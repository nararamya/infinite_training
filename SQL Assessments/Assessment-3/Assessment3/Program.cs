using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-D244D6GB;Database=assesment3;Integrated Security=True;";

       
            Console.Write("Enter the Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter the Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            
            int resProductId = 0;
            int resDiscountedPrice = 0;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("InsertProductDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;

         
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@Price", price);

         
            SqlParameter outputProductId = new SqlParameter("@resProductId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputProductId);

            SqlParameter outputDiscountedPrice = new SqlParameter("@resDiscountedPrice", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputDiscountedPrice);

            conn.Open();

           
            cmd.ExecuteNonQuery();

      
            resProductId = Convert.ToInt32(outputProductId.Value);
            resDiscountedPrice = Convert.ToInt32(outputDiscountedPrice.Value);

      
            Console.WriteLine($"Generated ProductId: {resProductId}");
            Console.WriteLine($"Discounted Price: {resDiscountedPrice}");

         
            conn.Close();
        }
    }
}
