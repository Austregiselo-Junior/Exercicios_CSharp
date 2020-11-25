using System;
using ExercicioProposto.Entities;
namespace ExercicioProposto.Services
{
    internal class S_Pagamento
    {
    
        private Interface1 _interface1;

        public S_Pagamento(Interface1 interface1)
        {
            _interface1 = interface1;
        }
        
        public void ProcessContracts(Contratc contratc, int month)
        {
            double basicQuota = contratc.ValordoContrato / month;
            
            for (int i = 1; i <= month; i++)
            {
                DateTime date = contratc.DatadoContrato.AddMonths(i);
                double updateQuota = basicQuota + _interface1.Interest(basicQuota, i);
                double fullQuota = updateQuota + _interface1.PaymentsFee(updateQuota);
                contratc.AddInstallment(new Parcelas(date, fullQuota));
            }
        }
    }
}
