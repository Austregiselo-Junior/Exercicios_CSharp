namespace ExerciciodeFixaxao
{
    internal class ContaBancaria
    {
        private int IOF = 5;
        public int NumeroDaConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroDaConta, string titular, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + IOF;
        }

        public override string ToString()
        {
            return $" Dados da conta -> {Titular}, {NumeroDaConta} e R${Saldo:F2}";
        }
    }
}
