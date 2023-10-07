using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------  Definindo uma expressão lambda que retorna o quadrado de um número inteiro ---------------------");
            // O exemplo a seguir define uma expressão lambda que retorna o quadrado de um número inteiro:

            DefinindoumaExpressaoLambdaqueRetornaoQuadradodeumNumeroInteiro();

            // Usando instrução lambsa
            UsandoInstricaoLambda();
            Console.ReadLine();

            Console.WriteLine("---------------  Convertendo uma expressão lambda em uma instância delegada ---------------------");
            //Quando o compilador C# encontra uma expressão lambda, ele converte a expressão lambda em uma instância delegada.
            //No exemplo abaixo, o compilador C# converte a expressão lambda em Func<int,int>. Veja o seguinte exemplo:
            // Como Func<int, int> aceita um número inteiro e retorna um número inteiro, não precisamos especificar explicitamente
            // o tipo do parâmetro de entrada da expressão lambda.Portanto, podemos omitir os parênteses.

            ConverteaexpressaoLambdaemumaInstanciaDelegada();
            Console.ReadLine();


            Console.WriteLine("---------------  Capturando variáveis ​​externas ---------------------");
            CapturandoVariaveisExternas();
            Console.ReadLine();
        }

        private static void DefinindoumaExpressaoLambdaqueRetornaoQuadradodeumNumeroInteiro() // Apenas para C# 10 ou superior
        {
            //var square = (int i) => i * i;
            //var result = square(10);
            //Console.WriteLine(result);
        }

        private static void UsandoInstricaoLambda() // Só para C# 10 ou sup, o int antes do (int x), especifica o tipo de retorno da expressão.
        {
            //var square = int (int x) => { return x* x; }
            //var result = square(10);
            //Console.WriteLine(result);
        }

        private static void ConverteaexpressaoLambdaemumaInstanciaDelegada() //Neste exemplo, declaramos o squarecomo uma instância do Func<int,int>.
        {
            Func<int, int> square = x => x * x;
            var result = square(10);
            Console.WriteLine(result);
        }

        private static void CapturandoVariaveisExternas() //É importante observar que a expressão lambda avalia as variáveis ​​
                                                          //capturadas quando é executada, não quando as variáveis ​​foram capturadas.
        {
            var multipliers = new List<Func<int, int>>(); // Definindo uma lista de expressão lambda aceitam um número inteiro e retornam um número inteiro

            for (int i = 1; i <= 3; i++)
            {
                int factor = i;
                multipliers.Add((int x) => x* factor);
            }

            foreach (var item in multipliers)
            {
                int result = item(10);
                Console.WriteLine(result);
            }
        }


    }


}
