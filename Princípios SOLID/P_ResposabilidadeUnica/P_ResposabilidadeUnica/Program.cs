using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_ResposabilidadeUnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando o objeto
            var invoice = new Invoice { InvoiceNo = 1, Customer = "Austro", Date = DateTime.Now.Date, Description = "Boleto da Pós", Amount = 1000 };

            // Salndo em uma classe especialista
            var invoiceRepository = new InvoiceRepository();
            invoiceRepository.Save(invoice);
            Console.ReadLine();
        }
    }
}
