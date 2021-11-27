using B11_Phieu3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B11_Phieu3.Objects
{
    class SP_LoaiSP
    {
        private string maSP;
        private string tenSP;
        private int? sL;
        private decimal? dG;
        private string tenLoai;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
       
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public int? SL { get => sL; set => sL = value; }
        public decimal? DG { get => dG; set => dG = value; }

        public SP_LoaiSP()
        {
        }
    }
}
