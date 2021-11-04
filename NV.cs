using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NV
    {
        private string maNV;
        private string hoTen;
        private bool gioiTinh;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public NV()
        {
        }

        public void nhap(string maNV, string hoTen, bool gioiTinh)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
        }

        internal void nhap()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            if(GioiTinh)
                return $"{MaNV, 10} {HoTen, 30} {"Nam", 10} {"-",15} {"-",15}";
            return $"{MaNV,10} {HoTen,30} {"Nữ",10} {"-",15} {"-",15}";
        }
    }
}
