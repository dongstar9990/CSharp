using System;
using System.Collections.Generic;

#nullable disable

namespace Bai12_Phieu1.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceCommodities = new HashSet<InvoiceCommodity>();
        }

        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Username { get; set; }

        public virtual User UsernameNavigation { get; set; }
        public virtual ICollection<InvoiceCommodity> InvoiceCommodities { get; set; }
    }
}
