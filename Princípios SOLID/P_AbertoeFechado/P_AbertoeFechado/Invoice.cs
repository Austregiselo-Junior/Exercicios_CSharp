using System;

namespace P_AbertoeFechado
{
    public class Invoice
    {
        public int InvoiceNo { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}