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
            float valuePurchase;
            Console.WriteLine("Введите стоимость покупки: ");
            valuePurchase = float.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки с учетом скидки = {Discount(valuePurchase, 0)}");
            Console.ReadKey();

        }

        private static float Discount(float discount, float purchaseAmount)
        {
            if (purchaseAmount > 100)
            {
                return purchaseAmount * discount / 100;
            }
            else
            {
                Console.WriteLine($"У вас нет скидки, сумма покупки = {purchaseAmount}");
                return purchaseAmount;
            }
        }
    }
}

