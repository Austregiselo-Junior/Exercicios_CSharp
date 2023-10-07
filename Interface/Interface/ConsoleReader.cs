using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ConsoleReader : IReadablecs
    {
        public string Escrevendo()
        {
            return "Escrevendoi arquivo";
        }

        public string Read()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
