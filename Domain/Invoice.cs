using System;
using System.Collections.Generic;

namespace Domain
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public User User { get; set; }
        public long Date { get; set; }
        public double Total { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
