using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Eventos_com_dados
{
    internal class OrderComDados
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        public void CreateComDados(string email, string cellFone)
        {
            Console.WriteLine("Order created");

            if (OnCreated != null) OnCreated(this, new OrderEventArgs { Email = email, Phone = cellFone });
            // This contêm a referência do próprio objeto
            // Observe que new OrderEventArgs, e a criação e a passagem dos valores do evento.
        }
    }
}
