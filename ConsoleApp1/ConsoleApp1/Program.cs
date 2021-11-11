/*
 * определить минимальный элемент первой и третей строки.
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
            Console.WriteLine($"Min element in 1st line of array = {GetMinNumberOfArrayLine(numbers, 0)} \n Min element in 3d line of array = {GetMinNumberOfArrayLine(numbers,2)}");
            
            
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

        //Сделаем один метод и вызовим его для двух рядов 1 и 3
        private static float GetMinNumberOfArrayLine(int[,] arr, int lineNumber)
        {
            //берем первый элемент из ряда и делаем его минимальным, который будем сравнивать с другими элементами
            int min = arr[lineNumber, 0];
            
            //только 1 цикл потому что ищем минимальный элемент только в одном ряду
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                //если элемент массива меньше минимального то минимальным становится этот элемент
                if (arr[lineNumber, j] < min)
                {
                    min = arr[lineNumber, j];
                }
            }

            return min;
        }
    }
}