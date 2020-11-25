namespace ExercicioRProposto.Services
{
    internal interface IcontractBank
    {
        double PaymentFee(double amount);
        double SimpleInterest(double amount, int month);
    }
}
