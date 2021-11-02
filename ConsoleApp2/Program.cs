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
            Task1();
            Task2();
            Task3(1, 2);
        }
        private static void Task2()
        {
            Console.WriteLine("Message");

        }
    private static void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void Task3(int a, int b) => Console.WriteLine($"Сумма = {a + b}"); 
    }
    
}

