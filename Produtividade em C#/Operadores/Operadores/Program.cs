using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Operador condicional nulo///
            OperadorCondicionalNulo();
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");

            /// Operador coalescência nula///
            OperadorCoalescênciaNula();
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");

            /// Operador Ternário///
            OperadirTernario();
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void OperadorCondicionalNulo()
        {
            var pessoa = new Pessoa();
            pessoa.Nome = "Austregiselo";

            var endereco = new Endereco() { Rua = "R. Sizenando de Oleiveira"};
            endereco = null;
            Console.WriteLine($"Nome: {pessoa?.Nome}, Rua: {endereco?.Rua}, Bairro: {pessoa?.Endereco?.Bairro}");
            /// Se o Endereco não tiver o ?, estoura um exceção de valor nulo.
            /// Se só o valor fosse null, a interpolação já faz a verificação, mas no naso acima é necessário o "?" porque ele verifica se a instância é nula.
        }

        public static void OperadorCoalescênciaNula()
        {
            var pessoa = new Pessoa();

            var nome = pessoa.Nome ?? "Não foi informado.";
            Console.WriteLine(nome);
            /// se pessoa.Nome for null, o retorno será "Não foi informado."
        }

        public static void OperadirTernario()
        {
            string classificacao;
            Console.WriteLine("Add sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            classificacao = (idade > 18) ? "Maior de idade" : "Menor de idade";
            Console.WriteLine(classificacao);
            /// se idade for maior que 18 o retorno é "Maior de idade", se não "Menor de idade"
        }

    }
}
