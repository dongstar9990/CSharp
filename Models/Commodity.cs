using System;
using System.Collections.Generic;

#nullable disable

namespace Bai12_Phieu1.Models
{
    public partial class Commodity
    {
        public Commodity()
        {
            InvoiceCommodities = new HashSet<InvoiceCommodity>();
        }

        public int CommodityCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<InvoiceCommodity> InvoiceCommodities { get; set; }
    }
}
