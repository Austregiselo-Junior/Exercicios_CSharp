using ByteBank.Funcionarios;
using ByteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public abstract class FuncionarioAutenticavel : Funcionariosf, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf) : base(cpf, salario)
        {
        }

      public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
