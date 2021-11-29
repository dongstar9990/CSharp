using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12_Phieu1.Objects
{
    class Item
    {
        public Item() { }

        public Item(int commodityCode, string name, decimal price, int quantity, decimal total, int invoiceCode)
        {
            CommodityCode = commodityCode;
            Name = name;
            Price = price;
            this.quantity = quantity;
            Total = total;
            InvoiceCode = invoiceCode;
        }

        public int CommodityCode { get; set; }
        public int InvoiceCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int quantity { get; set; }
        public decimal Total { get; set; }

        public static implicit operator List<object>(Item v)
        {
            throw new NotImplementedException();
        }
    }
}
