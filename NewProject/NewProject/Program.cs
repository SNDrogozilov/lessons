using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее значение = {newMain(a, b, c)}");
            Console.WriteLine($"Число {NewMain3(a, b, c)} наименьшее: ");


            Console.ReadLine();

        }
        public static float newMain(float a, float b, float c) => (a + b + c) / 3;

        public static float newMain2(float a, float b, float c)
        {
            if (a > b || b > c)
            {
                return a;
            }
            else if (b > a || b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public static float NewMain3(float a, float b, float c)
        {
            if (a < b || a < c)
            {
                Console.WriteLine($"Наименьшее число {a}");
                return float.Parse(Console.ReadLine());
            }
            else if (b < a || b < c)
            {
                Console.WriteLine($"Наименьшее число {b}");
                return float.Parse(Console.ReadLine());
            }
            else if (c < a || c < b)
            {
                Console.WriteLine($"Наименьшее число {c}");
                return float.Parse(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("Error");
                return float.Parse(Console.ReadLine());
            }

        }
    }
}
