using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12._2021
{
    internal class Infrastructure : Construction
    {
        public Infrastructure()
        {
            sand = 11000;
            bricks = 35000.2f;
            iron = 150000.45f;
            cement = 640000.12f;
            projectValue = 900000.3f;
        }
        public override void building()
        {
            Console.WriteLine("Инфраструктура строится");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"На постройку инфраструктуры необходимо песка: {sand}\nНа постройку инфраструктуры необходимо кирпича: {bricks}" +
                $"\nНа постройку инфраструктуры необходимо железа: {iron}\nНа постройку инфраструктуры необходимо цемента: {cement}" +
                $"\nСтоимость постройки: {projectValue}\n");
        }
    }
}
