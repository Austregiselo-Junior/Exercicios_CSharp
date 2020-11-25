namespace ExerciciosResolvidos.Entities
{
    internal class OutsousercedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsousercedEmployee()
        {
        }

        public OutsousercedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}
