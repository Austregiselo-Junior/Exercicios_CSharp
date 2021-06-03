using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{


   static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> ListaDeInteiros, params T[] itens)
        {
            foreach (var item in itens)
            {
                ListaDeInteiros.Add(item);
            }
        }

       
    }
}
