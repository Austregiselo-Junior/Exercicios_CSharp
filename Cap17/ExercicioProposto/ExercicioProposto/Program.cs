using ExercicioProposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExercicioProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter Salary: ");
            List<Employee> listEmployee = new List<Employee>();

            using (StreamReader stream = File.OpenText(path))
            {
                while (!(stream.EndOfStream))
                {
                    string[] vect = stream.ReadLine().Split(',');
                    string name = vect[0];
                    string email = vect[1];
                    double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);
                    listEmployee.Add(new Employee(name, email, salary));
                }
            }
            var sum = listEmployee.Select(p=> p.Email).

        }
    }
}
