using System;

namespace ExerciciodeFixaxao
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Informe os dados!");
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular: ");
            string cliente = Console.ReadLine();

            Console.Write("Terá depósito inicial? ");
            string Resp = Console.ReadLine();

            double Valor;
            ContaBancaria contaBancaria = new ContaBancaria(numero, cliente, 0);
            if (Resp == "Sim")
            {
                Console.Write("Qual valor? ");
                Valor = double.Parse(Console.ReadLine());
                contaBancaria.Deposito(Valor);
                Console.WriteLine(contaBancaria);
            }
            else
            {
                Console.WriteLine(contaBancaria);
            }


            while (contaBancaria.Saldo > 0)
            {
                Console.WriteLine("Deseja movimentar sua conta? ");
                Resp = Console.ReadLine();
                if (Resp == "Depositar")
                {
                    Console.Write("Qual o valor? ");
                    Valor = double.Parse(Console.ReadLine());
                    contaBancaria.Deposito(Valor);
                    Console.WriteLine(contaBancaria);

                }
                else if (Resp == "Sacar")
                {
                    Console.Write("Qual o valor? ");
                    Valor = double.Parse(Console.ReadLine());
                    contaBancaria.Saque(Valor);
                    Console.WriteLine(contaBancaria);
                }
            }
            if (contaBancaria.Saldo <= 0)
            {
                Console.WriteLine("Só será possível fazer depósitos!");
            }

            Console.ReadLine();
        }

    }
}

