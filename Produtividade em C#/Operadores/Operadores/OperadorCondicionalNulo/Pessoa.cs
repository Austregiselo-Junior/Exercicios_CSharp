using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
    }
}
