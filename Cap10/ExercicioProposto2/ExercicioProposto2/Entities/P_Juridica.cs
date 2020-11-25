namespace ExercicioProposto2.Entities
{
    internal class P_Juridica : ContribuicaoGeral
    {
        public int NumeroFuncionario { get; set; }

        public P_Juridica(string nome, double imposto, double rendaanual, int numeroFuncionario)
            : base(nome, imposto, rendaanual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        double balanco = 0;
        public override double Contribuicao()
        {
            //double balanco = 0;
            if (NumeroFuncionario > 10)
            {
                Imposto = 0.14;
                balanco = RendaAnual * Imposto;

            }
            else
            {
                Imposto = 0.16;
                balanco = RendaAnual * Imposto;
            }
            return balanco;
        }

        public override double Total()
        {
            return balanco + balanco;
        }


    }
}
