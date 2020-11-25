using ExercicioRProposto.Entities;
using ExercicioRProposto.Services;
using System;
using System.Globalization;

namespace ExercicioRProposto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter with contracts data:");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());


            Contratcs contratcs = new Contratcs(contractNumber, contractDate, contractValue); //Instanciação do contrato
            ServicePaymment servicePaymment = new ServicePaymment(new Paypal());  //Instanciando o banco por meio de injeção de dependencia
            ServicePaymment servicePaymment2 = new ServicePaymment(new Nubank());

            servicePaymment.ProcessContract(contratcs, numberInstallments); //Chamada do método "ProccesContracts", para entrar com o contrato e a quantidade de parcelas
            servicePaymment2.ProcessContract(contratcs, numberInstallments);


            Console.WriteLine();
            Console.WriteLine("Installments (Paypal, Nubank):");
            foreach (var itens in contratcs.InstallmentsList) //Varrendo a linta de parcelas através dos contratos (cada contrato tem suas parcelas)
            {
                Console.WriteLine(itens);
            }
            Console.ReadLine();

        }
    }
}
