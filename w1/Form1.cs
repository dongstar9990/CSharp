using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w1
{
    public partial class Form1 : Form
    {   
        private Model db =  new Model();
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tableProduct = new DataTable();
            tableProduct = controller.GetAllProduct();
            dgvKQ.DataSource = tableProduct;

            DataTable tableCategory = new DataTable();
            tableCategory = controller.GetAllCategory();
            cboTenHang.DataSource = tableCategory;
            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try {
                string maSP = textMaSP.Text.Trim();
                string tenSP = textTenSP.Text.Trim();
                string soLuong = textSoLuong.Text.Trim();
                string mauSac = textMauSac.Text.ToString().Trim();
                string giaBan = textGiaBan.Text.ToString().Trim();
                string maHang = cboTenHang.SelectedValue.ToString();

                if (String.IsNullOrWhiteSpace(maSP)) throw new Exception("Bạn chưa nhập mã sản phẩm");
                if (String.IsNullOrWhiteSpace(tenSP)) throw new Exception("Bạn chưa nhập tên sản phẩm");
                if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");
                if (String.IsNullOrWhiteSpace(mauSac)) throw new Exception("Bạn chưa nhập màu sắc sản phẩm");
                if (String.IsNullOrWhiteSpace(giaBan)) throw new Exception("Bạn chưa nhập giá bán sản phẩm");

                if (!int.TryParse(maSP, out int number))
                {
                    throw new Exception("Mã sản phẩm phải là số nguyên");
                }

                controller.InsertProduct(int.Parse(maSP), tenSP, mauSac, int.Parse(soLuong)
                    , int.Parse(giaBan), int.Parse(maHang));
                Form1_Load(sender, e);
            }
            catch (Exception ex){

                if(ex.Message.Contains("insert duplicate key")){

                    MessageBox.Show("Mã sản phẩm không được trùng","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = textMaSP.Text.Trim();
                string tenSP = textTenSP.Text.Trim();
                string soLuong = textSoLuong.Text.Trim();
                string mauSac = textMauSac.Text.ToString().Trim();
                string giaBan = textGiaBan.Text.ToString().Trim();
                string maHang = cboTenHang.SelectedValue.ToString();

                if (String.IsNullOrWhiteSpace(maSP)) throw new Exception("Bạn chưa nhập mã sản phẩm");
                if (String.IsNullOrWhiteSpace(tenSP)) throw new Exception("Bạn chưa nhập tên sản phẩm");
                if (String.IsNullOrWhiteSpace(soLuong)) throw new Exception("Bạn chưa nhập số lượng sản phẩm");
                if (String.IsNullOrWhiteSpace(mauSac)) throw new Exception("Bạn chưa nhập màu sắc sản phẩm");
                if (String.IsNullOrWhiteSpace(giaBan)) throw new Exception("Bạn chưa nhập giá bán sản phẩm");

                if (!int.TryParse(maSP, out int number))
                {
                    throw new Exception("Mã sản phẩm phải là số nguyên");
                }

                controller.EditProduct(int.Parse(maSP), tenSP, mauSac, int.Parse(soLuong)
                    , int.Parse(giaBan), int.Parse(maHang));
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("insert duplicate key"))
                {

                    MessageBox.Show("Mã sản phẩm không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                textMaSP.Text = dgvKQ.Rows[row].Cells[0].Value.ToString();
                textTenSP.Text = dgvKQ.Rows[row].Cells[1].Value.ToString();
                textMauSac.Text = dgvKQ.Rows[row].Cells[2].Value.ToString();
                textSoLuong.Text = dgvKQ.Rows[row].Cells[3].Value.ToString();
                int gia = Convert.ToInt32(dgvKQ.Rows[row].Cells[4].Value);
                textGiaBan.Text = gia.ToString();

                int maHang = int.Parse(dgvKQ.Rows[row].Cells[5].Value.ToString());
                cboTenHang.Text = controller.FindTenHangByMaHang(maHang);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(textMaSP.Text.ToString());
            controller.DeleteProductById(maSP);

            Form1_Load(sender,e);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            textMaSP.Clear();
            textTenSP.Clear();
            textSoLuong.Clear();
            textMauSac.Clear();
            textGiaBan.Clear();
            textMaSP.Clear();
            cboTenHang.SelectedIndex = 0;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Bạn muốn thoát ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(choose == DialogResult.Yes)
                Application.Exit();
        }
    }
}
