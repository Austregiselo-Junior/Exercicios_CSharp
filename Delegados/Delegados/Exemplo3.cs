using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    delegate void Greeting(string message);
    internal class Exemplo3
    {
        public static void SayHi(string name) => Console.WriteLine($"Hi {name}");
        public static void SayBye(string name) => Console.WriteLine($"Bye {name}");
        public static void Say(string message) => Console.WriteLine(message);
    }
}
