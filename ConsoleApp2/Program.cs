using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine($"Введите a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите c: ");
            c = double.Parse(Console.ReadLine());
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
            Console.ReadKey();
        }
    }
}

