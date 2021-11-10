using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = { 8, 5, 7, 1, 81, 44, 18, 101, -2 };
            SortArray(massive);
            
            Console.WriteLine("Отсортированный массив");
            ShowArray(massive);

            int lastArrayIndex = massive.Length - 1;
            int firstArrayIndex = 0;
            
            Console.WriteLine($"Max Element={massive[lastArrayIndex]}");
            Console.WriteLine($"Min Element={massive[firstArrayIndex]}");
            
            Console.WriteLine("Финальный массив");
            ShowArray(Swap(massive));
            
            Console.ReadLine();
        }

        private static void SortArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
        }

        private static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static int[] Swap(int[] arr)
        {
            int temp = arr[0];
            arr[0] = arr[arr.Length-1];
            arr[arr.Length-1] = temp;

            return arr;
        }
    }
}