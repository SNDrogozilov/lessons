using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12._2021
{
    public class Commercial_property : Construction
    {
        public Commercial_property ()
        {
            sand = 5000;
            bricks = 15000.4f;
            iron = 90000.55f;
            cement = 170050.55f;
            projectValue = 500000.58f;
        }
        public override void building()
        {
            Console.WriteLine("Коммерческая недвижимость строится");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"На постройку необходимо песка: {sand}\nНа постройку необходимо кирпича: {bricks}" +
                $"\nНа постройку необходимо железа: {iron}\nНа постройку необходимо цемента: {cement}" +
                $"\nСтоимость постройки: {projectValue}\n");
        }
        }
}
