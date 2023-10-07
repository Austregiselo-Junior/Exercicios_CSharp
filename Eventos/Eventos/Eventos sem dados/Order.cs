using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Eventos_sem_dados
{
    internal class Order
    {
        public event EventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("Pedido Criado!");

            if (OnCreated != null) OnCreated(this, EventArgs.Empty);
            // This contêm a referência do próprio objeto
            // Observe que EventArgs.Empty, fornece um valor a ser usado com um evento que não possui dados de evento.
        }
    }
}
