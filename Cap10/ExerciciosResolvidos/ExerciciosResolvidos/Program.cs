using ExerciciosResolvidos.Entities;
using System;
using System.Collections.Generic;
namespace ExerciciosResolvidos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorperhour = double.Parse(Console.ReadLine());

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsousercedEmployee(name, hours, valorperhour, additionalcharge)); //Só é possível fazer isso porque Outsouser... é extensão de Employee

                }
                else
                {
                    list.Add(new Employee(name, hours, valorperhour));
                }


            }

            Console.WriteLine();
            Console.WriteLine("---- Payments: ----");
            foreach (Employee item in list)
            {

                Console.WriteLine($"{item.Name}, R${item.Payment().ToString():F2}.");
            }
            Console.ReadLine();
        }
    }
}
