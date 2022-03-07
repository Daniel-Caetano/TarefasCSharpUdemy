using System;
using System.Globalization;
using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;

namespace ExercicioEnumComp
{
    internal class OrderMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            var client = new Client
            {
                Name = name,
                Email = email,
                BirthDate = birthDate
            };

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            var order = new Order(client, DateTime.Now , status);
            for (int i = 1; i <= numItems; i++)
            {
                var product = new Product();

                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                product.Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity=int.Parse(Console.ReadLine());

                var orderItem = new OrderItem(quantity,product.Price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
