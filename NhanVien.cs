using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class NhanVien : TinhLuong
    {
        private int maNV;
        private string chucVu;

        public int MaNV { get => maNV; set => maNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public NhanVien() { }

        public NhanVien(int maNV, string chucVu, string hoTen, string diaChi, int heSoLuong) : base(hoTen, diaChi, heSoLuong)
        {
            this.maNV = maNV;
            this.chucVu = chucVu;
        }

        public new long tinhLuong()
        {
            double phuCap = 0;
            if (chucVu.Equals("giám đốc")) phuCap = 0.5;
            else if (chucVu.Equals("trưởng phòng") || chucVu.Equals("phó giám đốc")) phuCap = 0.4;
            else if (chucVu.Equals("phó phòng")) phuCap = 0.3;

            return (long)((HeSoLuong + phuCap) * LuongCoBan);
        }

        public override string ToString()
        {
            return $"{maNV,15} {HoTen,20} {DiaChi,20} {chucVu,15} {HeSoLuong,15} {LuongCoBan,15} {tinhLuong(),20}";
        }
    }
}

