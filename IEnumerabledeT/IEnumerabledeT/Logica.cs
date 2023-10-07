using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabledeT
{
    internal class Logica
    {
      public IEnumerable<int> square(int max)
        {
            for (int i = 0; i < max; i++) { yield return i * i; } // com o Yeald é mais perfomático
        }
			
    }
}
