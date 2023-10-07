using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// Usanso interpolação de strings e verbatim "@" ///
            /// O verbatim @, serve pra preservar espaços, tabulações e definir caminho de arquivo.
            var msg = @"Amigo meito,
                                  Obrigado por tudo...
                       ótimo estudo.";
            Console.WriteLine($" Resposta:  {msg}");


            var caminhofake = @"C:\Users\austr\Downloads";
            Console.WriteLine($" Caminho fake:  {caminhofake}");
            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------");

            /// Convertendo strings em array de bytes
            string msge = "fefefefefefhrthrth5ehhh5hy";
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(msge);
            Console.WriteLine($" Array de bytes:  {bytes}");
            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------");

            /// Particionando uma string em um array de strings 
            string pensamento = @"Nosso cérebro é o melhor brinquedo já criado:
                          Nele se encontram todos os segredos, incluindo o da fecilidade.
                          A vida é maravilhosa se você não tem medo dela.";
            Console.WriteLine("Pensamento de Chaplin:");
            Console.WriteLine();
            Console.WriteLine(pensamento);
            Console.WriteLine();
            Console.WriteLine("Palávras:");
            Console.WriteLine();

            string[] lista = pensamento.Split(new Char[] { ' ', ',', '.', ':', '-', '\n', '\t' });

            foreach (string s in lista)
            {
                if (s.Trim() != "")
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");


            /// Validando se uma string é nulla ou vazia.
            string nome = string.Empty;
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine($"A variável {nome} está vazia.");
            }
            else
                Console.WriteLine($"A variável {nome} não está vazia.");

            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            /// Sorteando uma string de uma lista
            var funcionarios = new List<string>() { "Andre", "Juninho", "Gabriela" };

            Random random = new Random();
            int indicado = random.Next(funcionarios.Count);

            Console.WriteLine($"O escolhido: {indicado}.");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            ///Gerando uma string randomica, tipo senha de usuário
            Console.WriteLine(Convert.ToBase64String(Guid.NewGuid().ToByteArray()).ToString());
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");
        }


         /// Sobrescrevendo o método ToString()
         public override string ToString()
        {
            var name = "Austregiselo";
            var site = @"https://www.google.com.br/";

            return $"{name} , {site} ";
        }



    }
}
    




   

