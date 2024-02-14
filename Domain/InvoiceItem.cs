using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public int Sn { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
