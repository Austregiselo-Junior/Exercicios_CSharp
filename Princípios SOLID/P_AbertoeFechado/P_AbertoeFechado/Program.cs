using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_AbertoeFechado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice
            {
                InvoiceNo = 1,
                Customer = "John Doe",
                IssuedDate = DateTime.Now.Date,
                Description = "Website Design",
                Amount = 1000
            };

            // Da foprma que tá em baixo só criamos uma variável do tipo da interface que as classes implementam, assim reutilizamos
            // código e só criamos uma variável.
            IInvoiceRepository repo;

            Console.WriteLine("Salvando em arquivo"); 
            repo = new FileInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

            Console.WriteLine("Salvando no DB");
            repo = new DBInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

            Console.WriteLine("Salvando como JSON");
            repo = new JSONInvoiceRepository();
            repo.Save(invoice);
            Console.ReadLine();

        }
    }
}
