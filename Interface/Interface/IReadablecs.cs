using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IReadablecs : IEscrita // Uma interface pode herdar da outras, mas Obrigatóriamente quem implementa a primeira tem que implementar todas as outras interfaces.
    {
        string Read();
    }
}
