using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities
{
    class Parcelas
    {
        public DateTime DueDate { get; set; }
        public double  amount { get; set; }

        public Parcelas(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - " 
                + amount.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
