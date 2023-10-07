using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Eventos_sem_dados
{
    internal class Email
    {
        public static void Send(object sender, EventArgs e) // Os parâmetros do Send devem corresponder ao EventHandler OnCreated.
        {
            Console.WriteLine($"Send an email");
            
        }
    }
}
