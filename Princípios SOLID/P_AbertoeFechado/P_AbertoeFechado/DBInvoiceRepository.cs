using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_AbertoeFechado
{
    internal class DBInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into the database.");
        }
    }
}
