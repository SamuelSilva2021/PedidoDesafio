using PedidoDesafio.Entitites;
using PedidoDesafio.Entitites.Enums;
using System;
using System.Globalization;

namespace PedidoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter Cliente data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthData = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthData);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
               
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
