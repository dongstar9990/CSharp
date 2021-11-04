using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NVBH : NV
    {
        private int tienBanHang;

        public NVBH()
        {
        }

        public void nhap(string maNV, string hoTen, bool gioiTinh, int tienBanHang)
        {
            base.nhap(maNV, hoTen, gioiTinh);
            this.tienBanHang = tienBanHang;
        }

        public int TienBanHang { get => tienBanHang; set => tienBanHang = value; }

        public int tinhTienHoaHong()
        {
            if (tienBanHang >= 1000 && tienBanHang <= 5000)
                return (int)(0.1 * tienBanHang);
            else if (tienBanHang > 5000)
                return (int)(0.2 * tienBanHang);
            return 0;
        }

        public override string ToString()
        {
            if (GioiTinh)
                return $"{MaNV,10} {HoTen,30} {"Nam",10} {tienBanHang, 15} {tinhTienHoaHong(), 15}";
            return $"{MaNV,10} {HoTen,30} {"Nữ",10} {tienBanHang,15} {tinhTienHoaHong(),15}";
        }
    }
}
