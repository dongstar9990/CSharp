using System;
using System.Text;

namespace Buoi5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Employee a = new Employee();
            a.Input();
            a.Output();
        }
    }
}
