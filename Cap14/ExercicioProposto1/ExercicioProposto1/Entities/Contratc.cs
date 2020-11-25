using System;
using System.Collections.Generic;

namespace ExercicioProposto.Entities
{
    internal class Contratc
    {
        public int NumerodoContrato { get; set; }
        public DateTime DatadoContrato { get; set; }
        public double ValordoContrato { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contratc(int numerodoContrato, DateTime datadoContrato, double valordoContrato)
        {
            NumerodoContrato = numerodoContrato;
            DatadoContrato = datadoContrato;
            ValordoContrato = valordoContrato;
            Parcelas = new List<Parcelas>();
        }

        public void AddInstallment (Parcelas parcelas)
        {
            Parcelas.Add(parcelas);
        }
    }
}
