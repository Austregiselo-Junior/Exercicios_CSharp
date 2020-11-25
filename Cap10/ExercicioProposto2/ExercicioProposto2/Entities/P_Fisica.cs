using System;

namespace ExercicioProposto2.Entities
{
    internal class P_Fisica : ContribuicaoGeral
    {

              public double GastosSaude { get; set; }

        public P_Fisica(string nome, double imposto, double rendaAnual)
          : base(nome, imposto, rendaAnual)
        {
          
        }


        public P_Fisica(string nome, double imposto, double rendaAnual, double gastosSaude)
            : base(nome, imposto,rendaAnual)
        {
                      GastosSaude = gastosSaude;
        }
 double balanco = 0;
        public override double Contribuicao()
        {
           
            if (RendaAnual < 20000)
            {
                Imposto = 0.15;
                balanco = RendaAnual * Imposto; 
            }
            else if (RendaAnual >= 20000)
            {
                Imposto = 0.25;
                balanco = RendaAnual * Imposto;
            }
            if (RendaAnual < 20000 && GastosSaude != 0)
            {
                Imposto = 0.15;
                balanco = (RendaAnual * Imposto) - (GastosSaude*0.5);
            }
            else if (RendaAnual >= 20000 && GastosSaude != 0)
            {
                Imposto = 0.25;
                balanco = (RendaAnual * Imposto) - (GastosSaude * 0.5);
            }
           return balanco;
        }
        public override double Total()
        {
            return balanco + balanco;
        }
    }
}
