using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = { 1, 6, 0, 7, 5, 8, 3, 8, 5, 7, 4, 2, 4, 7, 3, 5, 7, 7, 4, 2, 9 };

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i] + " ");
            }
            Array.Sort(masiv);
            Array.Reverse(masiv);
            Console.WriteLine();

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i] + " ");
            }
            Console.Read();
        }
    }
}