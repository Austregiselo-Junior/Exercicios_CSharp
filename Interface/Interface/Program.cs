using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lendo arquivo atravpes de interface
            IReadablecs readablecs = new ConsoleReader();
            string input = readablecs.Read();

            IReadablecs readablecs2 = new FileReader("Caminho do arquivo");
            string content = readablecs2.Read();
            string content2 = readablecs2.Escrevendo();
            Console.WriteLine(content);
            Console.WriteLine(content2);
            Console.ReadLine();

            // Podemos passa uma interface como parâmetro de método

            IReadablecs[] readablecs3 = {new ConsoleReader(), new FileReader("Deu certo!")};

            foreach (var item in readablecs3)
            {
                Console.WriteLine(UpperCaseReader(item));
            }
            Console.ReadLine();
        }

        static string UpperCaseReader(IReadablecs readablecs) => readablecs.Read().ToUpper();

        // OBS: Tudo isso dá certo porque o tipo das variáveis são da interface e as classes em se implementam a mesma interface, da mesma forma o método 
        // que tem parâmetro do tipo da interface
        

    }
}
