using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionariosf
    {
        public Auxiliar(string cpf) : base(cpf, 1000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario *0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
