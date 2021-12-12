using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._12._2021
{
    public class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.building();
            house.ShowInfo();

            Commercial_property commercial_Property = new Commercial_property();
            commercial_Property.building();
            commercial_Property.ShowInfo();

            Infrastructure infrastructure = new Infrastructure();
            infrastructure.building();
            infrastructure.ShowInfo();
            
            Console.ReadLine();

        }
    }
}
