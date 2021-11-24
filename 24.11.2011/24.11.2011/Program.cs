using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._11._2011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: \t");
            double firstNomber = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: \t");
            double secondNomber = double.Parse(Console.ReadLine());
            double maxNomber = firstNomber > secondNomber? firstNomber: secondNomber;
            Console.WriteLine($"Максимальное число {maxNomber}");
            Console.ReadLine();
            SqareFigure();
            ChooseNumber();
        }
        public static void SqareFigure()
        {
            Console.WriteLine("Введите радиус круга \t");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата \t");
            double side = double.Parse(Console.ReadLine());
            double squareCircle = Math.PI * Math.Pow(radius, 2);
            double squareArea = Math.Pow(side, 2);
            double maxSqaure = squareArea < squareCircle ? squareCircle : squareArea;
            Console.WriteLine($"Площадь окружности = {squareCircle}, площадь квадрата = {squareArea}");
            Console.WriteLine($"Максимальная площадь {maxSqaure}");
            Console.ReadLine();
        }
        public static void ChooseNumber()
        {
            Console.WriteLine("Введите номер операции: 1. Сложение;\t 2. Вычитание;\t 3. Умножение;\t");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 числа. В зависимости от выбранноого типа операции, будет выполнено преобразование");
            Console.WriteLine("Введите первое число:\t");
            int countFirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:\t");
            int countSecondNumber = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine($"Сложение = {countFirstNumber+countSecondNumber}");
                    break;
                case 2: Console.WriteLine($"Вычитание = {countFirstNumber-countSecondNumber}");
                    break;
                case 3: Console.WriteLine($"Умножение = {countFirstNumber*countSecondNumber}");
                    break;
                default: Console.WriteLine("Операция не определена");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
