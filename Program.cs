using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int luaChon;

            List<NhanVien> dsNhanVien = new List<NhanVien>();

            while (true)
            {
                Console.WriteLine("1. Thêm nhân viên:");
                Console.WriteLine("2. Hiển thị danh sách: ");
                Console.WriteLine("3. Sắp xếp: ");
                Console.WriteLine("4. Thoát");
                Console.WriteLine("Nhập lựa chọn: ");

                luaChon = Int32.Parse(Console.ReadLine());

                if (luaChon == 4) break;

                switch (luaChon)
                {
                    case 1:
                        int maNV, heSoLuong;
                        string hoTen, diaChi, chucVu;

                        do
                        {
                            Console.WriteLine("Nhập mã nhân viên: ");
                            maNV = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Nhập họ tên nhân viên: ");
                            hoTen = Console.ReadLine();
                            Console.WriteLine("Nhập địa chỉ nhân viên: ");
                            diaChi = Console.ReadLine();
                            Console.WriteLine("Nhập hệ số lương nhân viên: ");
                            heSoLuong = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Nhập chức vụ nhân viên: ");
                            chucVu = Console.ReadLine();

                            
                            if (dsNhanVien.FindIndex(nv => nv.MaNV == maNV) != -1)                            
                            {
                                Console.WriteLine("Nhập lại do trùng id:");
                            }
                        } while (dsNhanVien.FindIndex(nv => nv.MaNV == maNV) != -1);
   
                        dsNhanVien.Add(new NhanVien(maNV, chucVu, hoTen, diaChi, heSoLuong));
                        break;
                    case 2:

                        dsNhanVien.ForEach(nv => Console.WriteLine(nv.ToString()));
                        break;
                    case 3:
                        dsNhanVien.Sort((a, b) => a.tinhLuong().CompareTo(b.tinhLuong()));
                        Console.WriteLine("Danh sách đã sắp xếp theo lương");
                        dsNhanVien.ForEach(nv => Console.WriteLine(nv.ToString()));
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không tồn tại");
                        break;
                }

            }
        }
    }
}
