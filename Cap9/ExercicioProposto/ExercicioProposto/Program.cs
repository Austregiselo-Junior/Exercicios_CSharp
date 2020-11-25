using ExercicioProposto.Entities;
using ExercicioProposto.Entities.Enum;
using System;

namespace ExercicioProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(Name, Email, BirthDate);
            Order order = new Order(DateTime.Now, Status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string NameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double PriceProduct = double.Parse(Console.ReadLine());
                Product product = new Product(NameProduct, PriceProduct);

                Console.Write("Quantity: ");
                int QuantityProduto = int.Parse(Console.ReadLine());
                Orderitem orderitem = new Orderitem(QuantityProduto, PriceProduct, product);
                order.AddItem(orderitem);
            }
            Console.WriteLine();

            Console.WriteLine("----  Order Summary  ----:");
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}

