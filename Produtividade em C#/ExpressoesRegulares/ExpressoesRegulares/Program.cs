using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressoesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var padrao = @"[0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2}";

            var resp = string.Empty;
            var regex = new Regex(padrao);

            while (true)
            {
                Console.WriteLine("CPF: ");
                resp = Console.ReadLine().Trim();
                if (resp.ToUpper().Equals("FIM")) break;
                string resultado = regex.IsMatch(resp) ? "Valido" : "Invalido";
                Console.WriteLine($"{resp}, é um valor {resultado}!\n");


            }




            Console.ReadLine();
        }


    }
}
