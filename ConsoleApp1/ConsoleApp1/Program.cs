using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = { 8, 5, 7, 1, 81, 44, 18, 101, -2 };
            int temp;
            int temp2;
            for (int i = 0; i < massive.Length - 1; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;

                    }
                }
            }
            Console.WriteLine("Отсортированный массив");

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[0] < massive[8])
                {
                    temp2 = massive[0];
                    massive[0] = massive[8];
                    massive[8] = temp2;

                }
                Console.WriteLine(massive[i]);
            }
            Console.ReadLine();
        }
    }
}
