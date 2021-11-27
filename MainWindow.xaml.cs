using B11_Phieu3.Models;
using B11_Phieu3.Objects;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace B11_Phieu3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new Controller();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgvView.ItemsSource = controller.getProducts();

            dgvView.Columns[2].DisplayIndex = 4;

            dgvView.Columns[0].Header = "Mã sản phẩm";
            dgvView.Columns[1].Header = "Tên sản phẩm";
            dgvView.Columns[2].Header = "Tên loại sản phẩm";
            dgvView.Columns[3].Header = "Đơn giá";
            dgvView.Columns[4].Header = "Số lượng";
            

        }

        private void dgvView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            foreach (var item in dgvView.SelectedItems)
            {
                SP_LoaiSP selected = (SP_LoaiSP)item;

                txtPCode.Text = selected.MaSP.Trim();
                txtPName.Text = selected.TenSP;
                txtPQuantity.Text = selected.SL.ToString();
                txtPPrice.Text = selected.DG.ToString();
                txtTCode.Text = controller.getIdProductTypeByName(selected.TenLoai).Trim();
            }

            /*if (dgvView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < dgvView.SelectedItems.Count; i++)
                {
                    SP_LoaiSP selected = (SP_LoaiSP)dgvView.SelectedItems[i];
                   
                    MessageBox.Show(selected.TenSP);
                }
            }*/
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pCode = txtPCode.Text.Trim().ToString();
            string pName = txtPName.Text.Trim().ToString();
            int pQuantity = Int32.Parse(txtPQuantity.Text.Trim().ToString());
            decimal pPrice = decimal.Parse(txtPPrice.Text.Trim().ToString());
            string tPCode = txtTCode.Text.Trim().ToString();

            int status = controller.addProduct(pCode, pName, pQuantity, pPrice, tPCode);

            if (status == 1)
            {
                txtPCode.Text = "";
                txtPName.Text = "";
                txtPQuantity.Text = "";
                txtPPrice.Text = "";
                txtTCode.Text = "";
            }
            

            Window_Loaded(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Bạn chắc chắn", "Muốn xoá sản phẩm này?", System.Windows.MessageBoxButton.YesNo);
            
            if(messageBoxResult == MessageBoxResult.Yes)
            {
                string pCode = txtPCode.Text.Trim().ToString();
                controller.deleteProductByCode(pCode);
                Window_Loaded(sender, e);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string pCode = txtPCode.Text.Trim().ToString();
            string pName = txtPName.Text.Trim().ToString();
            int pQuantity = Int32.Parse(txtPQuantity.Text.Trim().ToString());
            decimal pPrice = decimal.Parse(txtPPrice.Text.Trim().ToString());
            string tPCode = txtTCode.Text.Trim().ToString();

            controller.updateProductByCode(pCode, pName, pQuantity, pPrice, tPCode);

            Window_Loaded(sender, e);
        }
    }
}
