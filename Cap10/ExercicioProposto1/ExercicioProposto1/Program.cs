using ExercicioProposto1.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioProposto1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> listproducts = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write($"Commun, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    listproducts.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listproducts.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    listproducts.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("---- Price tags ----");

            foreach (Product item in listproducts)
            {
                Console.WriteLine(item.PriceTag());
            }
            Console.ReadLine();





        }
    }
}
