using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luaChon, luaChonNV;
            List<NV> dsNV = new List<NV>();

            string maNV, hoTen;
            string gioiTinh;
            int tienBanHang;

            while (true)
            {
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");

                Console.WriteLine("Nhap lua chon");
                luaChon = Int32.Parse(Console.ReadLine());

                if (luaChon == 4) break;

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("1.");
                        Console.WriteLine("2.");
                        luaChonNV = Int32.Parse(Console.ReadLine());

                        maNV = Console.ReadLine();
                        hoTen = Console.ReadLine();
                        gioiTinh = Console.ReadLine();

                        if(luaChonNV == 1)
                        {
                            NV nv = new NV();
                            if (gioiTinh.Equals("nam") || gioiTinh.Equals("Nam"))
                                nv.nhap(maNV, hoTen, true);
                            else
                                nv.nhap(maNV, hoTen, false);

                            dsNV.Add(nv);
                        }
                        else if(luaChonNV == 2)
                        {
                            tienBanHang = Int32.Parse(Console.ReadLine());
                            NVBH nvbh = new NVBH();
                            if (gioiTinh.Equals("nam") || gioiTinh.Equals("Nam"))
                                nvbh.nhap(maNV, hoTen, true, tienBanHang);
                            else
                                nvbh.nhap(maNV, hoTen, false, tienBanHang);
                            dsNV.Add(nvbh);
                        }
                        break;
                    case 2:
                        dsNV.ForEach(nv => Console.WriteLine(nv));
                        break;
                    case 3:
                        string maNVCapNhat = Console.ReadLine();

                        int index = dsNV.FindIndex(nv => nv.MaNV.Equals(maNVCapNhat));

                        if (index == -1) Console.WriteLine("Khong tim thay");
                        else
                        {
                            string hoTenCN, maNVCN;
                            string gioiTinhCN;
                            int tienBanHangCN;

                            hoTenCN = Console.ReadLine();
                            gioiTinhCN = Console.ReadLine();

                            dsNV[index].HoTen = hoTenCN;

                            if (gioiTinhCN.Equals("nam") || gioiTinhCN.Equals("Nam"))
                                dsNV[index].GioiTinh = true;
                            else
                                dsNV[index].GioiTinh = false;


                            if(dsNV[index].GetType() == typeof(NVBH))
                            {
                                tienBanHangCN = Int32.Parse(Console.ReadLine());
                                (dsNV[index] as NVBH).TienBanHang = tienBanHangCN;
                            }
                        }

                        break;
                }
            }
        }
    }
}
