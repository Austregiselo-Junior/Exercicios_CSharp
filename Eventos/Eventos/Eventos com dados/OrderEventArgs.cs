using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Eventos_com_dados
{
    internal class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
