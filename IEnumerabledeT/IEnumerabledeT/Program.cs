using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabledeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logica = new Logica();

            //IEnumerable<T>
            var squares = logica.square(5); // Essa linha não executa imediatamente o Square, porque ele tem op Yield, que faz com que seja aguardado o iterador

            foreach (var square in squares) { Console.WriteLine($"square: {square}"); }

            Console.ReadLine();

           // IEnumerable<T> e LINQ
           var numeros = new List<int> {1,5,2,8,9 };

            var addnumeros = numeros.Where(n => n % 2 != 0).Select(num => num);

            foreach (var item in addnumeros)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.ReadLine();
            // Neste exemplo, a oddNumbersvariável tem o tipo IEnumerable<int>.Devido à avaliação da consulta adiada, a consulta não é executada até a foreachinstrução.
        }
    }
}
