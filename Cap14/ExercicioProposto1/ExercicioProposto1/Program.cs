using ExercicioProposto.Entities;
using ExercicioProposto.Services;
using System;
using System.Globalization;

namespace ExercicioProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int numberContratic = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contratc contratc = new Contratc(numberContratic, date, value);
            S_Pagamento s_pagamento = new S_Pagamento(new Paypal());
            s_pagamento.ProcessContracts(contratc, numberInstallments);



            Console.WriteLine();
            Console.WriteLine("Installmensts:");
            foreach (var itens in contratc.Parcelas)
            {
                Console.WriteLine(itens);
            }
            Console.ReadLine();




        }
    }
}
