using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    class Funcionaio
    {
       public  string Nome;
       public  double SalarioBruto;
       public  double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto*porcentagem/100);
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}, salário líquido: R${SalarioLiquido():F2}"; 
        }
    }
}
