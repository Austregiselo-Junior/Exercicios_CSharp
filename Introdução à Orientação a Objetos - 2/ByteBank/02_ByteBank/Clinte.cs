using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Clinte
    {
        public string Nome { get; set; }
        public string _cpf { get; set; }

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public string Profissao { get; set; }
      
    }
}
