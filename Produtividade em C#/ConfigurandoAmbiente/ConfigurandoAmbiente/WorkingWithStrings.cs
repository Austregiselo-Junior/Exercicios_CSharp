using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurandoAmbiente
{
    internal static class WorkingWithStrings
    {
        /// <summary>
        /// Pode ser usado para por caminho de arquivo como: @"C:\User\caminho\exemplo".
        /// Como também na conexão de uma string, vide livro na parte de strig
        /// </summary>
        public static void TrabalhandoComArroba()
        {
            string Text = @"Amigo leitor,
  Obrigado por comprar este livro. Esperamos que ele ajude.
Bom estudo!";

            Console.WriteLine(Text);
        }



    }
}
