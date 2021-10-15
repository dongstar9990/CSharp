using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class TimUSCLN
    {
        private int a, b;

        public void Nhap()
        {
            Console.WriteLine("Nhập số thứ nhất: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai: ");
            b = Int32.Parse(Console.ReadLine());
        }

        public int TinhUCLN()
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a; 
        }

        public void Xuat()
        {
            Console.WriteLine($"UCLN của hai số {a} và {b} là {TinhUCLN()}");
        }
    }
}
