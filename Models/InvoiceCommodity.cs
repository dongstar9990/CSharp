using System;
using System.Collections.Generic;

#nullable disable

namespace Bai12_Phieu1.Models
{
    public partial class InvoiceCommodity
    {
        public int InvoiceNumber { get; set; }
        public int CommodityCode { get; set; }
        public int Quantity { get; set; }

        public virtual Commodity CommodityCodeNavigation { get; set; }
        public virtual Invoice InvoiceNumberNavigation { get; set; }
    }
}
