/*
 * Oпределить максимум и минимум массива.
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
            Console.WriteLine($"Max element of array = {GetMaxNumberArray(numbers)} \n Min element of array = {GetMinNumberArray(numbers)}");
            
            
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

        private static float GetMaxNumberArray(int[,] arr)
        {
            //за максимальный элемент берем первый элемент массива
            float max = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //если элемент массива больше максимального числа, то максимальным становится этот элемент
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }
        
        private static float GetMinNumberArray(int[,] arr)
        {
            //за минимальный элемент берем первый элемент массива
            float min = arr[0,0];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //если элемент массива меньше минимального числа, то минимальным становится этот элемент
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            return min;
        }
    }
}