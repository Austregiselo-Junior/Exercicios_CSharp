using ByteBank.Modelos;
using ByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerentedaConta : FuncionarioAutenticavel
    {
        public GerentedaConta(string cpf) : base(1000, cpf)
        {

        }

        public override double GetBonificacao()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
