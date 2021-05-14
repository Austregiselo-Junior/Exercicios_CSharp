using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; set; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

             throw new FileNotFoundException("Arquivo não encontrado.");
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

             throw new IOException("Arquivo não corrompido.");
            return "Linha do arquivo";
        }

      
        public void Dispose()
        {
              Console.WriteLine("Fechando arquivo.");
        }
    }
}
