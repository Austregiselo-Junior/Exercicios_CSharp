namespace ExercicioRProposto.Services
{
    internal class Paypal : IcontractBank
    {
        public double SimpleInterest { get; set; } = 0.01;
        public double PaymentFee { get; set; } = 0.02;

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
