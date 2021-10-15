using System;
using System.Text;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            GiaiPTBac2 pTBac2 = new GiaiPTBac2();
            pTBac2.Nhap();
            pTBac2.giaiPT();
        }
    }
}
