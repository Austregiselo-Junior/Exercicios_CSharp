using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------  Tipos genéricos ------");

            Console.WriteLine("------  Tipos genéricos sendo chamado como int ------");

            int x = 10, y = 20;
            Console.WriteLine($"Antes da chamada do método: x={x},y={y}"); // É necessário passar a variável criada, porque o parâmetro com "ref", funciona como um ponteiro.
            AlterandoParametros<int>(ref x, ref y);
            Console.WriteLine($"Após a chamada do método: x={x},y={y}");
            Console.ReadLine();

            Console.WriteLine("------  Tipos genéricos sendo chamado como string ------");
            string x1 = "Telbado";
            string y1 = "Malu";
            Console.WriteLine($"Antes da chamada do método: x1={x1},y1={y1}"); // É necessário passar a variável criada, porque o parâmetro com "ref", funciona como um ponteiro.
            AlterandoParametros<string>(ref x1, ref y1); // Observe que na chamada do mesmo método, devemos atualizar os parâmetros de acordo com as variáveis. 
            Console.WriteLine($"Após a chamada do método: x1={x1},y1={y1}");
            Console.ReadLine();
        }

        private static void AlterandoParametros<T>(ref T a, ref T b) 
        {
            T temp = a; a = b; b = temp;
        }
    }
}
