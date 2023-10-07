using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SubstituicaoLiskov
{
    internal class Onibus : Veiculo
    {
        public  void DriveOnibus() => Console.WriteLine("Dirigindo Onibus");
    }
}
