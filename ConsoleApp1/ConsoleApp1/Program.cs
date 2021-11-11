using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{3, 4, 7}, {32, 54, 765}, {54, 64, -27}, {33, 40, 78}};
            
            ShowArray(numbers);
            SumFirstLineArray(numbers);
            
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
        
        private static void SumFirstLineArray(int[,] arr)
        {
            int summa = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //break значит прервать выполнение, дальше не продолжать и выйти из цикла который сейчас выполняется.
                
                //так как "i" указывает на номер строки, а нам нужно найти сумму чисел только первой строки массива
                // поэтому дальше нам нету смысла продолжать выполнять цикл и нагружать систему. Поэтому мы прерываем выполнение
                
                if (i > 0) break;
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summa += arr[i, j];
                }
            }

            Console.WriteLine($"The summa of first line = {summa}");
        }
    }
}