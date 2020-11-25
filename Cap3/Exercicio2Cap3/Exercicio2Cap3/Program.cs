using System;

namespace Exercicio2Cap3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //  Treinando entrada de dados 
            /* string produto1 = "Computaddor";
             string produto2 = "Mesa de escritório";

             byte idade = 30;
             int codigo = 5290;
             char genero = 'M';

             double preco1 = 2100.0;
             double preco2 = 650.50;
             double medida = 53.234567;

             Console.WriteLine("Produtos:");
             Console.WriteLine($"{produto1}, cujo o preço é ${preco1}");
             Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
             Console.WriteLine();
             Console.WriteLine($"Resgistro: {idade}anos de idade, código {codigo} e gênero: {genero}");
             Console.WriteLine();
             Console.WriteLine($"Média com oito casas decimais: {medida:F8}," +
                 $"e arredondando para 3 casas decimáis fica: {medida:F3}. " +
                 $"Separador decimal com invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
             Console.ReadLine();

             //OBS: CultureInfor.Invariantculture -> Como o sistema do PC é em inglês ele sempre será expresso com "." em vez de ","
             */

            //  Treinando saída de dados 
            /*
                        Console.WriteLine("Entre com seu nome completo");
                        string Nome = Console.ReadLine();
                        Console.WriteLine($"Seu nome é {Nome}");

                        Console.WriteLine("Quantos quartos tem sua casa?");
                        int Quartos = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Sua casa tem {Quartos}");

                        Console.WriteLine("Entre como preço de um produto");
                        double Preco = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O preço é {Preco}");

                        Console.WriteLine("Entre seu último nome, idade e altura");
                        string[] vet = Console.ReadLine().Split();
                        string NomeVet = vet[0];
                        int IdadeVet = int.Parse(vet[1]);
                        double AlturaVet = double.Parse( vet[2]);
                        Console.WriteLine($"Seu ultimo nome é {NomeVet}, você tem idade {IdadeVet} e altura {AlturaVet}");
                        Console.ReadLine();
                        */

            // Treinando funções 
            /*
            Console.WriteLine("Digite três números");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int Resultado = Maior(A,B,C);
            Console.WriteLine($"O Maior é {Resultado}");
            Console.ReadLine();



            int Maior(int a,int b,int c)
            {
                int R;
                if(a > b && a > c)
                {
                    R = a;
                }
                else if(b > c && b > a)
                {
                    R = b;
                }
                else
                {
                    R = c;
                }
                return R;


            }
            */

            // Treinando estruturas de repetição
            /*
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                double raiz = Math.Sqrt(n);
                Console.WriteLine($"O valor é {raiz}");
                Console.WriteLine("Digite outro número: ");
                n = int.Parse(Console.ReadLine());

            }

            while(n < 0)
            {
                Console.WriteLine($"O valor é negatigo!");
                Console.WriteLine("Digite outro número: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
            */

            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor é #{0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
     Console.WriteLine($"A soma é {soma}");
            }
       
            Console.WriteLine();








        }
    }
}
