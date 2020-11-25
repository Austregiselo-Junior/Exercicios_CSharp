namespace ExercicioProposto2.Entities
{
    internal abstract class ContribuicaoGeral
    {
        public string Nome { get; set; }
        public double Imposto { get; set; }
        public double RendaAnual { get; set; }

        protected ContribuicaoGeral(string nome, double imposto, double rendaanual)
        {
            Nome = nome;
            Imposto = imposto;
            RendaAnual = rendaanual;
        }

        public abstract double Contribuicao();

        public abstract double Total();

    }


}

