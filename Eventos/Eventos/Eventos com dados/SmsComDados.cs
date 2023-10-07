using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Eventos_com_dados
{
    internal class SmsComDados
    {
        public static void SendComDados(object sender, OrderEventArgs e) // Os parâmetros do Send devem corresponder ao OrderEventArgs OnCreated.
        {
            Console.WriteLine($"Send an email to {e.Phone}");
        }
    }
}
