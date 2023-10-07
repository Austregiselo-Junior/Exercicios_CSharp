using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicionaisedeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversaComTiciane();
            Console.ReadLine();

            ReconhecerFaseDaVida(22);
            ValidacaodeSexo("F");
            Console.ReadLine();
        }

        private static void ConversaComTiciane()
        {
            Console.WriteLine("Fazendo as pazes...");
       

            Console.WriteLine("Adicione os nomes:");
            var nome1 = Console.ReadLine();
            var nome2 = Console.ReadLine();

            Console.WriteLine($"{nome1}: Ei vei, bora ficar assim não.");
            Console.WriteLine($"{nome1}: Tão quando a gente fica junto e se ajuda, uma verdadeira parceria");
            Console.ReadLine();

            Console.WriteLine($"{nome2}: ÉÉÉÉ MAS VC FICA ME COBRANNNDDDOOO POWWWW, QUE SACO!!!");
            Console.WriteLine($"{nome2}: JÁ FALEI QUE NÃO QUERO NADA SÉRIO COM NINGUÉM...");
            Console.ReadLine();

            Console.WriteLine($@"{nome1}: Eu sei pow, mas é que a pergunta no domingo foi combrando não.
Foi porque sei como é voltar de farra, sempre tem perigo porque ninguém dorme direito");
            Console.WriteLine($"{nome1}: Depois eu fiquei puto e falei o que não devia... ");
            Console.ReadLine();

            Console.WriteLine($"{nome1}: Bora voltar a ser leve que é o melhor que fazemos.");
            Console.WriteLine($"{nome1}: Lembre que o universo disse que é bom pra os dois ficarem juntos kkkk.");
            Console.ReadLine();

            Console.WriteLine($"PS. {nome1} está apelando...");





            Console.ReadLine();
        }

        private static void ReconhecerFaseDaVida(int idade)
        {
            var fase = string.Empty;

            switch (idade) 
            {
                case int i when i <= 11:
                    fase = "Infancia";
                    break;
                
                case int i when i >= 12 && i <= 19:
                    fase = "Adolescencia";
                    break;

                case int i when i >= 20:
                    fase = "Adulto";
                    break;
            }
            Console.WriteLine($"{idade} anos = {fase}");
        }

        private static void ValidacaodeSexo(string sexo) 
        {
            switch (sexo)
            {
                case var i when i is "M":
                    Console.WriteLine("O sexo é masculino.");
                    break;

                    case var i when i is "F":
                    Console.WriteLine("O sexo é feminino.");
                    break;

                default:
                    Console.WriteLine("O sexo não foi informado.");
                    break;
            }
        }
    }
}
