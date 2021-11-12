/*
 * Создать зубчатый (ступенчатый) массив (массив массивов) на "n" массивов и
 * заполнить каждый из этих массивов на "m" элементов
 */

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Main Arr Length: ");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[][] arr=new int[arrLength][];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Input length of {i} array: ");
                int insideArrLength = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[insideArrLength];
                
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Input {j} element of {i} array: ");
                    int arrElement = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = arrElement;
                }
            }

            Console.WriteLine("\nYour Array\n");
            ShowArray(arr);
            
            Console.ReadLine();
        }

        private static void ShowArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} \t");
                }

                Console.WriteLine();
            }
        }
    }
}