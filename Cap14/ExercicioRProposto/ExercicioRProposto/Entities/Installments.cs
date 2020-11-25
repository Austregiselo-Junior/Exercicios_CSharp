using System;

namespace ExercicioRProposto.Entities
{
    internal class Installments
    {
        public DateTime DuoDate { get; set; }
        public double Value { get; set; }

        public Installments(DateTime duoDate, double value)
        {
            DuoDate = duoDate;
            Value = value;
        }
        public override string ToString()
        {
      
            return $"Data: {DuoDate} - valor: R${Value}";
        }


    }
}
