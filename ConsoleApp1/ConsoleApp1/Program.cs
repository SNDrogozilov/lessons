﻿/*
 * Найти количество четных и нечетных чисел в массиве
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
            Console.WriteLine($"Even Amount in array = {GetEvenNumbersAmountOfArray(numbers)} \n Odd Amount in array = {GetOddNumbersOfArray(numbers)}");
            
            
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

        //Четное число
        private static float GetEvenNumbersAmountOfArray(int[,] arr)
        {
            int evenNumbersAmount = 0;
            
            //только 1 цикл потому что ищем количество четных чисел только в одном ряду
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //если элемент массива четный то увеличиваем счетчик найденных четных чисел
                    if (arr[i, j] % 2 == 0)
                    {
                        evenNumbersAmount++;
                    }
                }
                
            }

            return evenNumbersAmount;
        }
        
        //Нечетное число
        private static float GetOddNumbersOfArray(int[,] arr)
        {
            int oddNumbersAmount = 0;
            
            //только 1 цикл потому что ищем количество нечетных чисел только в одном ряду
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //если элемент массива нечетный то увеличиваем счетчик найденных нечетных чисел
                    if (arr[i, j] % 2 != 0)
                    {
                        oddNumbersAmount++;
                    }
                }
            }

            return oddNumbersAmount;
        }
    }
}