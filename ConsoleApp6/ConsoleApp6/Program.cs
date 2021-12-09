using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Denomination denomination = new Denomination();
            denomination.Resalt();

            CoinDenomination coinDenomination = new CoinDenomination();
            coinDenomination.Resalt();

            ProductPrice productPrice = new ProductPrice();
            productPrice.Resalt();

            CaloryValue caloryValue = new CaloryValue();
            caloryValue.Resalt();

            MinutesTotalSec minutesTotalSec = new MinutesTotalSec();
            minutesTotalSec.Resalt();

            Hours hours = new Hours();
            hours.Resalt();

            Console.ReadLine();

        }
        public class Denomination
        {
            public int denomination;
            public int billAmount;

            public Denomination()
            {
                denomination = 10;
                billAmount = 100;
            }
            public void Resalt()
            {
                Console.WriteLine($"Сумма купюр номиналом {denomination} = {denomination * billAmount}");
            }
        }
        public class CoinDenomination
        {
            public int coinDenomination;
            public int coinsAmount;

            public CoinDenomination()
            {
                coinDenomination = 5;
                coinsAmount = 30;
            }
            public void Resalt()
            {
                Console.WriteLine($"Сумма монет {coinDenomination} = {coinDenomination / coinsAmount}");
            }
        }
        public class ProductPrice
        {
            public float productPrice;
            public int goodsUnits;

            public ProductPrice()
            {
                productPrice = 100.6f;
                goodsUnits = 13;
            }
            public void Resalt()
            {
                Console.WriteLine($"Общая стоимость {productPrice} часах = {productPrice / goodsUnits}");
            }
        }
        public class CaloryValue
        {
            public float caloryValue;
            public float productWeightInGram;

            public CaloryValue()
            {
                caloryValue = 145.5f;
                productWeightInGram = 11.6f;
            }
            public void Resalt()
            {
                Console.WriteLine($"Общее количество калорий в 100 граммах = {caloryValue / productWeightInGram}");
            }
        }
        public class MinutesTotalSec
        {
            public int minutesTotalSec;
            public int seconds;

            public MinutesTotalSec()
            {
                minutesTotalSec = 30;
                seconds = 40;
            }
            public void Resalt()
            {
                Console.WriteLine($"Общее количество минут в {minutesTotalSec} минутах = {minutesTotalSec * 60 / seconds}");
            }
        }
        public class Hours
        {
            public int hours;
            public int minutesTotalMin;

            public Hours()
            {
                hours = 2;
                minutesTotalMin = 5;
            }
            public void Resalt()
            {
                Console.WriteLine($"Общее количество минут в {hours} часах = {hours * 60 / minutesTotalMin}");
            }
        }
    }
}
