using Eventos.Eventos_com_dados;
using Eventos.Eventos_sem_dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email = Eventos.Eventos_sem_dados.Email;
using Order = Eventos.Eventos_sem_dados.Order;
using Sms = Eventos.Eventos_sem_dados.Sms;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Evento sem passagem de informaçâo entre publicador (Order) e assitante (Email e Sms).
            var orderSemDados = new Order();

            orderSemDados.OnCreated -= Email.Send; // Sempre e boa prática desassinar antes de assinar (anbind)
            orderSemDados.OnCreated += Email.Send; // Assinatura (Bind)
            orderSemDados.OnCreated -= Sms.Send; // Sempre e boa prática desassinar antes de assinar (anbind)
            orderSemDados.OnCreated += Sms.Send; // Assinatura (Bind)

            orderSemDados.Create();

            Console.ReadLine();


            // Evento com passagem de informaçâo entre publicador (OrderComDados) e assitante (EmailComDados e SmsComDados).
            var orderComDados = new OrderComDados();
            orderComDados.OnCreated -= EmailComDados.SendComDados; // Sempre e boa prática desassinar antes de assinar (anbind)
            orderComDados.OnCreated += EmailComDados.SendComDados; // Assinatura (Bind)

            orderComDados.OnCreated -= SmsComDados.SendComDados; // Sempre e boa prática desassinar antes de assinar (anbind)
            orderComDados.OnCreated += SmsComDados.SendComDados; // Assinatura (Bind)

            orderComDados.CreateComDados("john@test.com", "(408)-111-2222");
            Console.ReadLine();
        }
    }
}
