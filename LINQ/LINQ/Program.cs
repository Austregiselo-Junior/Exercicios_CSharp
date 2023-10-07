using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Linq com sintaxe de consulta --");
            LinqSintaxedeConsulta();
            Console.ReadLine();

            Console.WriteLine("-- Linq com sintaxe de método --");
            LinqcomSintaxedeMetodo();
            Console.ReadLine();
        }

        private static void LinqcomSintaxedeMetodo()
        {
            var nb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var eventNb = nb.Select(y => y).Where(x => x % 2 == 0); // Pego a lista nb filtro e depois selecionando os filtrados e projeto uma nova lista.

            foreach (var item in eventNb)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinqSintaxedeConsulta()
        {
            var nb = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var eventNb = from number in nb where number % 2 == 0 select number;

            foreach (var number in eventNb) { Console.WriteLine(number); }
        }
    }
}
