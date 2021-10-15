using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi5
{
    class Employee
    {
        const int PRICE = 50;
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Workingdays { get => workingdays; set => workingdays = value; }

        public double getSalary()
        {
            return this.workingdays * PRICE;
        }

        public void Input()
        {
            Console.WriteLine("Nhập mã nhân viên: ");
            this.id = Console.ReadLine();
            Console.WriteLine("Nhập tên nhân viên: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi nhân viên: ");
            this.age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số ngày công của nhân viên: ");
            this.workingdays = Int32.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Mã nhân viên: {this.id}");
            Console.WriteLine($"Tên nhân viên: {this.name}");
            Console.WriteLine($"Tuổi nhân viên: {this.age}");
            Console.WriteLine($"Số ngày công nhân viên: {this.workingdays}");
            Console.WriteLine($"Lương nhân viên: {this.getSalary()}");
        }
    }
}
