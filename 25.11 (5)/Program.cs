using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11__5_
{
    public class Example
    {
        public static void Main()
        {
            int[] first = { 1, 4, 5 };
            int[] second = { 6, 7 };

            int[] result = first.Concat(second).ToArray();

            Console.WriteLine(String.Join(", ", result));        // 1, 4, 5, 6, 7
        }
    }
}