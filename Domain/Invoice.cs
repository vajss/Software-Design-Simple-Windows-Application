using System;

namespace Domain
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
    }
}
