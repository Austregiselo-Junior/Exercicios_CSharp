using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    internal static class Exemplo1
    {
      public delegate void Greeting(string message);
      public  static void SayHi(string name) // Esse método deve ter a mesma assinatura do Greeting delegado que está na classe Program.
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
