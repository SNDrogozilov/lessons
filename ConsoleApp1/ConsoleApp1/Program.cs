/*
 * 1)	Вывести на экран у форме таблицы:

3	4	7
32	54	765
54	64	-27
33	40	78

 */
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{3, 4, 7}, {32, 54, 765}, {54, 64, -27}, {33, 40, 78}};
            
            ShowArray(numbers);
            
            Console.ReadLine();
        }

        private static void ShowArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}