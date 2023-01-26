using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0-dan
                     kiçik, 100 - dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın.Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.

                   Bal 20 - dən kiçik olarsa "İmtahandan kəsildiniz" yazın.                   20 - dən böyük və ya bərabər, 40 - dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"                   40 - dan böyük və ya bərabər, 60 - dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"                   60 - dan böyük və ya bərabər, 80 - dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"                   80 - a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
           */
            string examPointStr = Console.ReadLine();

            int examPoint = 0;
            bool parsePoint = int.TryParse(examPointStr, out examPoint);

            if (!parsePoint)
            {
                Console.WriteLine("Xahis olunur reqem daxil edin!");
            }
            else if(examPoint < 0 || examPoint > 100)
            {
                Console.WriteLine("Duzgun bal daxil edilmeyib.");
            }
            else if (examPoint < 20)
            {
                Console.WriteLine("Imtahandan kesildiniz!");
            }
            
            
            
        }
    }
}
