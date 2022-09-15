using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsLager = new Dictionary<string, decimal>();
            
            List<Product> productsList = new List<Product>();

            string[] productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (productInfo[0]!="buy")
            {
                string name = productInfo[0];
                decimal price = Convert.ToDecimal(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (!productsList.Any(p => p.Name == name))
                {
                    Product product = new Product
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity
                    };
                    productsList.Add(product);
                }
                else
                {
                    int currIndex = productsList.FindIndex(n => n.Name == name);
                    productsList[currIndex].Price = price;
                    productsList[currIndex].Quantity += quantity;
                }

                productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in productsList)
            {
                productsLager.Add(item.Name, item.Price * item.Quantity);
            }

            foreach (var item in productsLager)
            {
                Console.WriteLine($"{item.Key} -> { item.Value:f2}");
            }

        }
        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }
}
