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
            double valuePurchase;
            Console.WriteLine("Введите стоимость покупки: ");
            valuePurchase = double.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки с учетом скидки = {Discount(valuePurchase, 0)}");
            Console.ReadKey();

        }
        public static double Discount(double discount, double purchaseAmount)
        {
            purchaseAmount = discount;
            discount *= 0.1;
            if (purchaseAmount > 100)
            {
                return purchaseAmount - discount;
            }
            else
            {
                Console.WriteLine($"У вас нет скидки, сумма покупки = {purchaseAmount}");
                return purchaseAmount;
            }

        }
    }
}

