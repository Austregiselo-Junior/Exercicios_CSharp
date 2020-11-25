namespace ExercicioProposto.Services
{
    internal class Paypal : Interface1
    {
        public double FeePercentage { get; private set; } = 0.02;
        public double MonthlyInterest { get; private set; } = 0.01;

        public double Interest (double value, int month)
        {
            return value * MonthlyInterest * month;
        }

        public double PaymentsFee(double value)
        {
            return value * FeePercentage;
        }
    }
}
