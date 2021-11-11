/*
 * Определить среднее арифметическое каждой строки
 */

using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{3, 4, 7}, {32, 54, 765}, {54, 64, -27}, {33, 40, 78}};
            
            ShowArray(numbers);
            AverageOfLinesArray(numbers);
            
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
        
        private static void AverageOfLinesArray(int[,] arr)
        {
            int summaOfLine = 0;
            int dimensionsAmount = arr.GetLength(0);
            int numbersAmountInLine = arr.GetLength(1);
            
            for (int i = 0; i < dimensionsAmount; i++)
            {
                for (int j = 0; j < numbersAmountInLine; j++)
                {
                    //получаем сумму чисел в строке
                    summaOfLine += arr[i, j];
                }

                Console.WriteLine($"Average of line {i} = {GetAverage(summaOfLine, numbersAmountInLine)}");
                
                //Обнуляем сумму чисел в строке чтоб нормально посчитать среднее арифметическое следующей строки
                summaOfLine = 0;
            }
        }

        private static float GetAverage(float summ, int numbersAmount) => summ / numbersAmount;
    }
}