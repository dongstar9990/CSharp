using System;
using System.Text;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimUSCLN[] ucln = new TimUSCLN[100];
            int n;

            Console.WriteLine("nhập số lượng phần tử: ");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ucln[i] = new TimUSCLN();
                ucln[i].Nhap();
            }

            for (int i = 0; i < n; i++)
            {
                ucln[i].Xuat();
            }
        }
    }
}
