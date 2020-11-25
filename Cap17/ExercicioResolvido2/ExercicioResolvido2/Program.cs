using System;
using ExercicioResolvido2.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> List = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    List.Add(new Product(name, price));
                }
            }

            var avg = List.Select(p => p.Price).DefaultIfEmpty(0.0).Average();//Retorna a média da lista mas se a lista for vazia através dp "DefaltIfEmpty" ele retorna 0.0
            Console.WriteLine("Average price = " + avg.ToString("F2"), CultureInfo.InvariantCulture);

            var listName = List.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var item in listName)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
