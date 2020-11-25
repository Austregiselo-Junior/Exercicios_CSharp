using ExercicioProposto.Entities;
using ExercicioProposto.Exeptions;
using System;

namespace ExercicioProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Número da conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saudoinicial = double.Parse(Console.ReadLine());
                Console.Write("Limite para saque: ");
                double limite = double.Parse(Console.ReadLine());
                Account account = new Account(numero, nome, saudoinicial, limite);

                Console.WriteLine();
                Console.Write("Quanto será sacado? ");
                double saque = double.Parse(Console.ReadLine());
                account.Withdraw(saque);
            }
            catch (DomainException msg)
            {
                Console.WriteLine($"Erro ao sacar: {msg.Message}");
            }

            catch (FormatException msg)
            {
                Console.WriteLine($"Erro de formatação: {msg.Message}");
            }
            Console.ReadLine();


        }
    }
}
