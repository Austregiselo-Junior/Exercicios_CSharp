using ByteBank.Modelos;
using ByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
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
