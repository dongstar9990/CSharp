using B11_Phieu3.Models;
using B11_Phieu3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace B11_Phieu3
{
    class Controller
    {
        private SanPhamDBContext context = new SanPhamDBContext();

        public List<SP_LoaiSP> getProducts()
        {
            var data = context.SanPhams.Join(
                    context.LoaiSanPhams,
                    sp => sp.MaLoai,
                    loai => loai.MaLoai,
                    (sp, loai) => new SP_LoaiSP
                    {
                        MaSP = sp.MaSp,
                        TenSP = sp.TenSp,
                        SL = sp.SoLuong,
                        DG = sp.DonGia,
                        TenLoai = loai.TenLoai,
                    }
                ).ToList();

            return data;
        }

        public string getIdProductTypeByName(string name)
        {

            var code = context.LoaiSanPhams.Where(p => p.TenLoai == name).FirstOrDefault<LoaiSanPham>();
            return code.MaLoai;
        }

        public int addProduct(string pCode, string pName, int pQuantity, decimal pPrice, string tPCode)
        {
            try
            {
                SanPham sp = new SanPham
                {
                    MaSp = pCode,
                    TenSp = pName,
                    DonGia = pPrice,
                    MaLoai = tPCode,
                    SoLuong = pQuantity
                };

                context.SanPhams.Add(sp);
                context.SaveChanges();

                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Mã sản phẩm không được trùng");
                return -1;
            }
        }

        public void deleteProductByCode(string pCode)
        {
            var product = context.SanPhams.Where(p => p.MaSp.Equals(pCode)).First();

            if(product == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
            }else
            {
                context.SanPhams.Remove(product);
                context.SaveChanges();
            }
        }

        public void updateProductByCode(string pCode, string pName, int pQuantity, decimal pPrice, string tPCode)
        {
            var product = context.SanPhams.Where(p => p.MaSp.Equals(pCode)).First();

            if (product == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
            }
            else
            {
                product.TenSp = pName;
                product.SoLuong = pQuantity;
                product.MaLoai = tPCode;
                product.DonGia = pPrice;
                context.SaveChanges();
            }
        }
    }
}
