using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    internal class Program
    {
        delegate int Transforme(int x);
        static int i = 30;
        static int j = 20;

        static void Main(string[] args)
        {
            // Método anônimo é um método sem nome que é atribuído a um delegado, pode ser de forma explicita setando o método ou não
            // como da segunda vez em que criamos o delegado e o atribuimos a um bloco de código

            Transforme transformeComCriacaodeMetodo = square;
            Console.WriteLine(transformeComCriacaodeMetodo(10));
            Console.ReadLine();


            Transforme transforme = delegate (int x)
            { return i * j; };
            Console.WriteLine(transforme(20));
            Console.ReadLine();
        }
        static int square(int x) => x * x;
    }
}
