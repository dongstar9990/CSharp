using System;
using System.Collections.Generic;

#nullable disable

namespace B11_Phieu3.Models
{
    public partial class SanPham
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string MaLoai { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }

        public virtual LoaiSanPham MaLoaiNavigation { get; set; }
    }
}
