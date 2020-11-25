using System;
using System.Collections.Generic;

namespace ExercicioRProposto.Entities
{
    internal class Contratcs
    {
        public int ContratcNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContratcValue { get; set; }
        public List<Installments> InstallmentsList { get; set; }

        public Contratcs(int contratcNumber, DateTime contractDate, double contratcValue)
        {
            ContratcNumber = contratcNumber;
            ContractDate = contractDate;
            ContratcValue = contratcValue;
            InstallmentsList = new List<Installments>(); //Deve iniciar as listas de forma vazia
        }

        public void AddInstallments(Installments installments)
        {
            InstallmentsList.Add(installments);
        }
    }
}
