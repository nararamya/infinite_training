using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product();
                Console.WriteLine("Enter the product Id:");
                product.ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product name:");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                product.Price = Convert.ToDouble(Console.ReadLine());

                products.Add(product);
            }
            var sortedProducts = products.OrderBy(p => p.Price).ToList();

            Console.WriteLine("Sorted products by price");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine("ID:{0},Name:{1},Price:{2}",product.ProductId,product.ProductName,product.Price);
            }
            Console.Read();
        }
    }
}
