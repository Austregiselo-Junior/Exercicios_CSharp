using ExercicioRProposto.Entities;
using System;

namespace ExercicioRProposto.Services
{
    internal class ServicePaymment
    {
        private IcontractBank _Bank;

        public ServicePaymment(IcontractBank Bank)
        {
            _Bank = Bank;
        }

        public void ProcessContract(Contratcs contratcs, int month)
        {
            double basicQuota = contratcs.ContratcValue / month;

            for (int i = 1; i <= month; i++)
            {
                DateTime date = contratcs.ContractDate.AddMonths(i);
                double updateQuota = basicQuota + _Bank.SimpleInterest(basicQuota, i); //Chama o método do banco para fazer as operações, em vez da própria classe implementar
                double fullQuota = updateQuota + _Bank.PaymentFee(updateQuota); //Chama o método do banco para fazer as operações, em vez da própria classe implementar = (updateQuota + (0.02 * valor)) = fullQuota
                contratcs.AddInstallments(new Installments(date, fullQuota)); //chamada do método "AddInstallments" para adicionar parcelas com suas datas e valores
            }
        }
    }
}
