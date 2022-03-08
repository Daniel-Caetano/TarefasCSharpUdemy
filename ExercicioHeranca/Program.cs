using ExercicioHeranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numProduct = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();
            for (int i = 1; i <= numProduct; i++)
            {
                Product product = new Product();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                product.Name = Console.ReadLine();
                Console.Write("Price: ");
                product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == "c")
                {
                    products.Add(product);
                }
                else if (type == "u")
                {
                    UsedProduct usedProduct = new UsedProduct(product.Name,product.Price);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    usedProduct.ManufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(usedProduct);
                }
                else if (type == "i")
                {
                    ImportedProduct importedProduct = new ImportedProduct(product.Name, product.Price);
                    Console.Write("Customs fee: ");
                    importedProduct.customsFee= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(importedProduct);
                }
                else
                {
                    Console.WriteLine("Invalid command!! digite novamente");
                    i--;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
