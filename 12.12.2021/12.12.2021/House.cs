using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12._2021
{
        public class House : Construction
        {
            public House()
            {
                sand = 3000;
                bricks = 10000.4f;
                iron = 75000.55f;
                cement = 150000.55f;
                projectValue = 100000.58f;
            }
            public override void building()
            {
                Console.WriteLine("Дома строятся");
            }
            public void ShowInfo()
            {
                Console.WriteLine($"На постройку дома необходимо песка: {sand}\nНа постройку дома необходимо кирпича: {bricks}" +
                    $"\nНа постройку дома необходимо железа: {iron}\nНа постройку дома необходимо цемента: {cement}" +
                    $"\nСтоимость постройки дома: {projectValue}\n");
            }
        }
}
