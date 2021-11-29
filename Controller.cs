using Bai12_Phieu1.Models;
using Bai12_Phieu1.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Bai12_Phieu1
{
    
    class Controller
    {
        private b12_phieu1Context ctx = new b12_phieu1Context();

        public User login(string username, string password)
        {
            var query = from u in ctx.Users
                       where u.Username == username && u.Password == password                       
                       select u;

            var user = query.FirstOrDefault<User>();
            return user;
        }

        public User getInfoByPhone(string phone)
        {
            var query = from u in ctx.Users
                        where u.Phone == phone
                        select u;

            var user = query.FirstOrDefault<User>();
            return user;
        }

        public Commodity getCommodityByCode(int code)
        {
            var query = from c in ctx.Commoditys
                        where c.CommodityCode == code
                        select c;

            var commodity = query.FirstOrDefault<Commodity>();
            return commodity;
        }

        public int createInvoice(int invoiceNumber, DateTime invoiceDate, string username)
        {
            var invoice = ctx.Invoices.Where(i => i.InvoiceNumber == invoiceNumber).FirstOrDefault();

            if (invoice == null)
            {
                ctx.Invoices.Add(new Invoice { InvoiceNumber = invoiceNumber, InvoiceDate = invoiceDate, Username = username });
                ctx.SaveChanges();
                return 1;
            }else
            {                 
                MessageBox.Show("Số hoá đơn không được trùng");
                return -1;
            }     

        }

        public int order(int invoiceNumber, int commodityCode, int quantity)
        {
            var invoice = ctx.Invoices.Where(i => i.InvoiceNumber == invoiceNumber);
            var commodity = ctx.Commoditys.Where(c => c.CommodityCode == commodityCode);

            if(invoice == null)
            {
                MessageBox.Show("Số hoá đơn không tồn tại");
                return -1;
            }
            
            if(commodity == null)
            {
                MessageBox.Show("Mã hàng không tồn tại");
                return -1;
            }

            ctx.InvoiceCommodities.Add(new InvoiceCommodity { InvoiceNumber = invoiceNumber, CommodityCode = commodityCode, Quantity = quantity });
            ctx.SaveChanges();
            return 1;
        }

        public List<Item> getOders(int invoiceCode)
        {
            var items = ctx.Invoices.Join(
                    ctx.InvoiceCommodities,
                    i => i.InvoiceNumber,
                    ic => ic.InvoiceNumber,
                    (i, ic) => new { i, ic }
                 ).Join(
                    ctx.Commoditys,
                    ic => ic.ic.CommodityCode,
                    c => c.CommodityCode,
                    (ic, c) => new Item
                    {
                        CommodityCode = c.CommodityCode,
                        Name = c.Name,
                        Price = c.Price,
                        quantity = ic.ic.Quantity,
                        Total = c.Price * ic.ic.Quantity,
                        InvoiceCode = ic.i.InvoiceNumber,
                    }
                 ).Where(i => i.InvoiceCode == invoiceCode).ToList();
            return items;
        }

        public void renameColumn(DataGrid dataGrid)
        {
            dataGrid.Columns[0].Header = "Mã Hàng";
            dataGrid.Columns[2].Header = "Tên Hàng";
            dataGrid.Columns[3].Header = "Đơn giá";
            dataGrid.Columns[4].Header = "Số lượng";
            dataGrid.Columns[5].Header = "Thành tiền";

        }
    }
}
