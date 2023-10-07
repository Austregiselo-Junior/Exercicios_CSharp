using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------  Criando um tipo anônimo -----------------------");
            // O exemplo a baixo mostra a criação de um tipo anônimo atravé do "new".

            var product = new { Name = "Phone X", Price = 99.00 }; // Observe que não há o tipo especificado como seria numa classe.
            Console.WriteLine($"{product.Name}, {product.Price}");

            Console.WriteLine("-------------------------  Criando tipos anônimos com tipos explicito -----------------------");
            TiposAnonimosdeTipoExplicito();
            Console.ReadLine();

        }

        private static void TiposAnonimosdeTipoExplicito()
        {
            var product = new
            {
                Name = "Phone X",
                Price = 99.9,
                atribute = new Atributos() { Color = "Black", Weight = 100 },
            };

            Console.WriteLine($"Name: {product?.Name}, Color: {product.atribute?.Color}");

        }


    }
}
