using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadoBonificacao
    {
        private double _totalBonificacao;

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
        public void Registrar(Funcionariosf funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }     
    }
}
