using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_ResposabilidadeUnica
{/// <summary>
/// Responsabilidade de criar a entidades
/// </summary>
    internal class Invoice
    {
        public int InvoiceNo { get;  set; }
        public DateTime Date { get;  set; }
        public string Customer { get;  set; }
        public decimal Amount { get;  set; }
        public string Description { get;  set; }
    }
}
