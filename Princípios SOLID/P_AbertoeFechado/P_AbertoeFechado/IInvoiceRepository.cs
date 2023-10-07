using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_AbertoeFechado
{
    internal interface IInvoiceRepository
    {
        void Save(Invoice invoice);
    }
}
