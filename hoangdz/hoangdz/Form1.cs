using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoangdz
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tableProduct = new DataTable();
            tableProduct = controller.GetAllProduct();
            dgv.DataSource = tableProduct;

            DataTable tableNote = new DataTable();
            tableNote = controller.GetAllNote();
            cboLuuY.DataSource = tableNote;
            cboLuuY.DisplayMember = "TenLuuY";
            cboLuuY.ValueMember = "MaLuuY";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text.Trim();
            string tenHang = txtTenHang.Text.Trim();
            string maLuuY = cboLuuY.SelectedValue.ToString();
            string ngaySX = dtpNSX.Value.ToString("yyyy-MM-dd");
            string soLuong = txtSoLuong.Text.Trim();

            controller.InsertProduct(int.Parse(maHang), tenHang, ngaySX, int.Parse(soLuong), int.Parse(maLuuY));
            Form1_Load(sender, e);
        }
    }
}
