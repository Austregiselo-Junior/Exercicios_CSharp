
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(43243244, 3);
            conta.Titular = new Clinte(); //Instanciando o cliente a uma conta através do atributo titular

            ContaCorrente conta3 = new ContaCorrente(4334244, 345);
            conta.Titular.Nome = "Austregiselo";
            conta.Titular.CPF = "096.781.563232";
            conta.Titular.Profissao = "Dev C#";
            conta.Saldo = 1000;


            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.ReadLine();
        }
    }
}
