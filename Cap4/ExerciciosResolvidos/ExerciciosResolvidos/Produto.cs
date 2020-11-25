using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        

       public double ValorTotalemEstoque()
        {
            return Preco * Quantidade; 
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return $"Atualização -> Nome: {Nome}, preço: R${Preco:F2}, " +
         $" quantidade em estoque {Quantidade} unidades e valor total em estoque: R${ValorTotalemEstoque().ToString("F2")}";
        }

        public void Atualizacao()
        {
            Console.WriteLine($"Atualização -> Nome: {Nome}, preço: R${Preco:F2}, " +
         $" quantidade em estoque {Quantidade} unidades e valor total em estoque: R${ValorTotalemEstoque().ToString("F2")}");
        }
    
    }
}
