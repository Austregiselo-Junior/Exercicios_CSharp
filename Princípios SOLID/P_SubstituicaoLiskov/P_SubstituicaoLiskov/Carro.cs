using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SubstituicaoLiskov
{
    internal class Carro : Veiculo
    {
        public  void DriveCarro() => Console.WriteLine("Dirigindo um carro");
    }
}
