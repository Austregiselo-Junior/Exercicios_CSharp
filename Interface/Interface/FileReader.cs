using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class FileReader : IReadablecs
    {
        public string FileName { get; set; }

        public FileReader(string fileName) => FileName = fileName;

        public string Read()
        {
            return "Deu certo!";
        }

        public string Escrevendo()
        {
            return "Escrevendo arquivo";
        }
    }
}
