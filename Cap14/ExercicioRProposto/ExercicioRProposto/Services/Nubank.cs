namespace ExercicioRProposto.Services
{
    internal class Nubank : IcontractBank
    {
        public double SimpleInterest { get; set; } = 0.02;
        public double PaymentFee { get; set; } = 0.15;

        double IcontractBank.PaymentFee(double amount)
        {
            return amount * PaymentFee;
        }

        double IcontractBank.SimpleInterest(double amount, int month)
        {
            return amount * SimpleInterest * month;
        }

    }
}