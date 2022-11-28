using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dtDate;
            string strDate;
            CultureInfo provider = CultureInfo.CreateSpecificCulture("ru-RU");
            DateTimeStyles styles = DateTimeStyles.None;

            string strSuccess = "'{0}' -> {1}";
            string strFailure = "Ошибка: '{0}'.";

            strDate = "30.10.2021";

            if (DateTime.TryParse(strDate, provider, styles, out dtDate))
            {
                Console.WriteLine(strSuccess, strDate, dtDate);
            }
            else
            {
                Console.WriteLine(strFailure, strDate);
            }

            strDate = "10.30.2021";
            if (DateTime.TryParse(strDate, provider, styles, out dtDate))
            {
                Console.WriteLine(strSuccess, strDate, dtDate);
            }
            else
            {
                Console.WriteLine(strFailure, strDate);
            }
        }
    }
}
