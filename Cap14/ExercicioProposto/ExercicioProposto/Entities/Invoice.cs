using System.Globalization;

namespace ExercicioProposto.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic paument: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\ntax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
