using Bai12_Phieu1.Models;
using Bai12_Phieu1.Objects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai12_Phieu1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Item> listItem = new List<Item>();

        private Controller controller = new Controller();

        private User user;
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            user = (User)Tag;
            txtUsername.Text = user.Username;            
            dtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void TextBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtFullname.Text = "";
            string phone = txtPhone.Text.Trim().ToString();
            var user = controller.getInfoByPhone(phone);

            if (user != null)
            {
                txtFullname.Text = user.FullName;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtCommodityCode.Text.ToString().Length != 0)
            {
                int code = Int32.Parse(txtCommodityCode.Text.ToString());
                var commodity = controller.getCommodityByCode(code);

                if (commodity != null)
                {
                    txtCommodityName.Text = commodity.Name;
                    txtCommodityPrice.Text = commodity.Price.ToString();
                }
            }         
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal total = decimal.Parse(txtCommodityPrice.Text.ToString()) * Int32.Parse(txtCommodityQuantity.Text.ToString());
            int commodityCode = Int32.Parse(txtCommodityCode.Text.ToString());

            int invoiceCode = -1;

            if (txtInvoiceCode.Text.ToString().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn");
                return;
            }
            else
            {
                invoiceCode = Int32.Parse(txtInvoiceCode.Text.ToString());
            }
            

            string name = txtCommodityName.Text.ToString();
            decimal price = decimal.Parse(txtCommodityPrice.Text.ToString());
            int quantity = Int32.Parse(txtCommodityQuantity.Text.ToString());
            
            listItem.Add(new Item(commodityCode, name, price, quantity, total, invoiceCode));

            dgvView.ItemsSource = listItem;
            dgvView.Columns[1].Visibility = Visibility.Hidden;

            controller.renameColumn(dgvView);

            dgvView.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int invoiceCode = Int32.Parse(txtInvoiceCode.Text.ToString().Trim());

            DateTime invoiceDate = DateTime.Now;

            int invoiceStatus = controller.createInvoice(invoiceCode, invoiceDate, user.Username);

            if(invoiceStatus == 1)
            {
                foreach (var item in listItem)
                {
                    controller.order(invoiceCode, item.CommodityCode, item.quantity);
                }

                listItem.Clear();
            }

            MessageBox.Show("Lưu thành công");
            
        }

        private void txtInvoiceCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a, invoiceCode;
            bool isParse = Int32.TryParse(txtInvoiceCode.Text.Trim().ToString(), out a);

            listItem.Clear();

            if (isParse)
            {
                invoiceCode = Int32.Parse(txtInvoiceCode.Text.Trim().ToString());
                dgvView.ItemsSource = controller.getOders(invoiceCode);
                dgvView.Columns[1].Visibility = Visibility.Hidden;
                controller.renameColumn(dgvView);
            }
            else
            {
                dgvView.ItemsSource = null;
            }
        }
    }
}
