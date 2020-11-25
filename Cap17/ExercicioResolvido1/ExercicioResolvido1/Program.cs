using System;
using System.Linq;
using ExercicioResolvido1.Entities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido1
{
    class Program
    {

        static void print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); //Consulta com Linq usando a espressão lambda
            print("Tier 1 and price < 900.0", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //Nomes da cadegotia Tools, selecionando só o nomes
            print("Name of products from tools",r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });// Com objeto anonimo = objeto que não está declarado em nenhuma das classes
            //OBS: Tem que haver o apelido "CategoyName", porque há dois Names, uma na classe Categoy e outro na classe Product
            print("Names Startedwith 'C' and anonymous object", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // Ordena por preço e os que tem preço iguaais são ordenados por nome através do "ThenBy" 
            print("Tier 1 order by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);
            print("Tier 1 order by price then by name, skip 2 take 4", r5);
            Console.ReadLine();
        }
    }
}
