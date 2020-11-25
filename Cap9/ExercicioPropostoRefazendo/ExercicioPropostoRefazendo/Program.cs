using ExercicioPropostoRefazendo.Entities;
using ExercicioPropostoRefazendo.Entities.Enums;
using System;

namespace ExercicioPropostoRefazendo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter client data!");
            Console.Write("Name: ");
            string namecliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailcliente = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYY)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter order data: ");
            Client client = new Client(namecliente, emailcliente, date);
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            Console.WriteLine();

            Console.Write("How many items to the order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Product product = new Product(name, price);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("---- Order Summary ----");
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}
