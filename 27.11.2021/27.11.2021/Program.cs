using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Showinfo("Вася", 14, "щ8шр");

            Employee employee1 = new Employee("Павел", 40, "Уборщик");
            employee1.Showinfo();
            Console.ReadLine();
        }
        public class Employee
        {
            public string name;
            public int age;
            public string position;
            public Employee()
            {
                name = "Sergey";
                age = 30;
                position = "Manager";
            }
            public Employee(string name, int age, string position)
            {
                this.name = name;
                this.age = age;
                this.position = position;
            }

            public void Showinfo()
            {
                Console.WriteLine($"{name}, {age}, {position}");
            }
            public void Showinfo(string name, int age, string position)
            {
                Console.WriteLine($"{name}, {age}, {position}");
            }
        }

    }
}