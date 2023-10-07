using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_ResposabilidadeUnica
{
    internal class InvoiceRepository
    {
        public void Save(Invoice invoice) => Console.WriteLine($"Os dados foram salvos {invoice.InvoiceNo}");
    }
}
