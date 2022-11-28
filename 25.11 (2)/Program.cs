using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strDate = new string[]
{
    "08/18/2018 07:22:16",
    "08/18/2018",
    "8/2018",
    "8/18",
    "07:22:16",
    "7 PM",
    "2018-08-18T07:22:16.0000000Z",
    "2018-08-18T07:22:16.0000000-07:00",
    "Sat, 18 Aug 2018 07:22:16 GMT",
    "08/18/2018 07:22:16 -5:00"
};
            foreach (string str in strDate)
            {
                DateTime dt;
                if (DateTime.TryParse(str, out dt))
                {
                    Console.WriteLine($"{dt}");
                }
                else
                    Console.WriteLine("Ошибка парсинга");


            }
        }
    }
}
