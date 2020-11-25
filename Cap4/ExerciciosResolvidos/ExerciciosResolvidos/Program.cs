using System;

namespace ExerciciosResolvidos
{
    internal class Program
    {
        private static void Main(string[] args)
        {/*
            double px;
            double py;
            double arex;
            double arey;

            Console.WriteLine("Entre com os lados do triângulo X");
            double lx1 = double.Parse(Console.ReadLine());
            double lx2 = double.Parse(Console.ReadLine());
            double lx3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os lados do triânlugo Y");
            double ly1 = double.Parse(Console.ReadLine());
            double ly2 = double.Parse(Console.ReadLine());
            double ly3 = double.Parse(Console.ReadLine());

            px = (lx1 + lx2 + lx3) / 2;
            arex = Math.Sqrt(px * (px - lx1) * (px - lx2) * (px - lx3));
            Console.WriteLine($"A área do triângulo x é {arex:F2}");

            py = (ly1 + ly2 + ly3) / 2;
            arey = Math.Sqrt(py * (py - ly1) * (py - ly2) * (py - ly3));
            Console.WriteLine($"A área do triângulo y {arey:F2}");
            if(arex > arey)
            {
                Console.WriteLine($"A maior área é do triângulo x");
            }
            else
            {
                Console.WriteLine($"A maior área é do triângulo y");
            }
            Console.ReadLine();
            */

            /*
            Produto produto = new Produto();
            Console.WriteLine("-------  Gestão de estoque  ------");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(produto);
            // produto.Atualizacao();

            Console.Write("Quantos produtos serão gerenciados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("Deseja remover ou adicionar? ");
                string Resposta = Console.ReadLine();
                if(Resposta == "add")
                {
                    Console.Write("Deseja adicionar quantos produtos? ");
                    int quant = int.Parse(Console.ReadLine());
                    produto.AdicionarProduto(quant);
                }
                else
                {
                    Console.Write("Deseja remover quantos produtos? ");
                    int quant = int.Parse(Console.ReadLine());
                    produto.RemoverProduto(quant);
                }
                Console.WriteLine(produto);
               // produto.Atualizacao();
            }
            */


            Console.ReadLine();

        }
    }
}


