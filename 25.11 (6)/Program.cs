using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11__6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: "); //приглашение пользователю ввести число
            int n = Convert.ToInt32(Console.ReadLine()); //преобразуем введенную пользователем строку в число и присваиваем его значение переменной
            //считаем абсолютную разность
            int result;
            if (n > 48)
                result = (n - 48) * 3; //n больше 48, значит выводим тройную разность
            else
                result = 48 - n; //абсолютная разность - всегда положительна, поэтому меняем n и 48 местами
            Console.WriteLine(result);
        }
    }
}
