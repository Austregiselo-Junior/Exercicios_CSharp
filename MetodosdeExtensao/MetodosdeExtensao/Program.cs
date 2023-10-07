using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodosdeExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando métodos de extensão 'ToTitleCase'");
            var message = "C# extension methods are cool";
            Console.WriteLine(message.ToTitleCase());
            Console.ReadLine();

            Console.WriteLine("métodos de extensão para estender o tipo int adicionando dois métodos IsEven()e IsOdd():");

            int[] ListNumber = { 1, 2, 3, 4, 54, 6, 7, 8, 9, 10, 11, 22, 33 };

            foreach (var item in ListNumber.Where(item => item.IsEven()))
            {
                Console.WriteLine($"Números Pares {item}");
            }
            _ = Console.ReadLine();

            foreach (var item in ListNumber.Where(item => item.IsOdd()))
            {
                Console.WriteLine($"Números Ímpares {item}");
            }
            _ = Console.ReadLine();
        }
    }

    static class StringExtensions 
    {
        public static string ToTitleCase(this string value) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
    }
}
