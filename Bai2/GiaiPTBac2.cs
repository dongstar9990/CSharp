using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class GiaiPTBac2
    {
        private int a, b, c;

        public GiaiPTBac2(){}

        public GiaiPTBac2(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Nhap()
        {
            Console.WriteLine("nhập a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhập b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhập c: ");
            c = Int32.Parse(Console.ReadLine());
        }

        public void giaiPT()
        {
            if (a == 0)
            {
                Console.WriteLine("PT không phải pt bậc 2");
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("PT vô nghiệm");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"PT có 2 nghiệm kép x1=x2={-b / (2 * a)}");
            }
            else
            {
                delta = Math.Sqrt(delta);
                double x1 = (-b + delta) / (2 * a);
                double x2 = (-b - delta) / (2 * a);
                Console.WriteLine($"PT có 2 nghiệm phân biệt");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }
    }
}
