using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class TinhLuong
    {
        protected string hoTen;
        protected string diaChi;
        protected int heSoLuong;
        protected static long luongCoBan = 1000000;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public static long LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public TinhLuong() {  }

        public TinhLuong(string hoTen, string diaChi, int heSoLuong)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.heSoLuong = heSoLuong;
        }

        public long tinhLuong()
        {
            return this.HeSoLuong * LuongCoBan;
        }

    }
}
