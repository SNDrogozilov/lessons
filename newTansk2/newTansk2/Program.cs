using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTansk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list2 = new List<string>();
            List<string> list = new List<string>() { "New", "New1", "New2" };
            Console.WriteLine("values list");
            GetListValues(list);
            Console.WriteLine("values list2");
            GetListValues(list2);
            Console.WriteLine("ListValues in progress");
            ListValues(list, list2);
            Console.WriteLine("values list2");
            GetListValues(list2);
            Console.ReadKey();
        }
        static void GetListValues(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void ListValues(List<string> fullList, List<string> emptyList)
        {
            foreach (string item in fullList)
            {
                emptyList.Add(item);
            }
        }
    }
}
