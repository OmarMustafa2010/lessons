using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0-dan
                       kiçik, 100-dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın. Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.
                       
                       Bal 20-dən kiçik olarsa "İmtahandan kəsildiniz" yazın.
                       20-dən böyük və ya bərabər, 40-dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"
                       40-dan böyük və ya bərabər, 60-dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"
                       60-dan böyük və ya bərabər, 80-dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"
                       80-a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
             */
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string examPointStr = Console.ReadLine();
            int exampPoint = 0;

            bool parsePoint = int.TryParse(examPointStr, out exampPoint);

            if (!parsePoint)
                Console.WriteLine("Xahis olunur bir reqem daxil edin");
            else if (exampPoint < 0 || exampPoint > 100)
                Console.WriteLine("Düzgün bal daxil edilməyib");
            else if (exampPoint < 20)
            {
                Console.WriteLine("İmtahandan kəsildiniz");
            }
            else if (exampPoint >= 20 && exampPoint < 40)
            {
                Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                Console.WriteLine("Netice: qenaetbexs");
            }
            else if (exampPoint >= 40 && exampPoint < 60)
            {
                Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                Console.WriteLine("Netice: kafi");
            }
            else if (exampPoint >= 60 && exampPoint < 80)
            {
                Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                Console.WriteLine("Netice: yaxsi");
            }
            else if (exampPoint >= 80)
            {
                Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
                Console.WriteLine("Netice: Ela");
            }


            var firstname = "Orkhan";
            var surname = "Farajov";
            var dateOfBirth = new DateTime(1995, 12, 24);
            var job = "Developer";

            if(firstname == "Orkhan" && surname == "Farajov")
            {
                if(dateOfBirth.Year == 1995 && dateOfBirth.Month == 12 && dateOfBirth.Day == 24)
                {
                    if(job == "Developer")
                    {
                        Console.WriteLine("Xos geldin " + firstname);
                    }
                    else
                    {
                        Console.WriteLine("Job yanlisdir!");
                    }
                }
                else
                {
                    Console.WriteLine("Dogum tarixi yanlisdir!");
                }
            }
            else
            {
                Console.WriteLine("Ad ve ya Soyad yanlisdir!");
            }



            Console.Clear();


            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cixma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bolme");

            var op = Convert.ToInt16(Console.ReadLine());
            var a1 = Convert.ToInt16(Console.ReadLine());
            var b1 = Convert.ToInt16(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Netice: " + (a1 + b1));
            }
            else if (op == 2)
            {
                Console.WriteLine("Netice: " + (a1 - b1));
            }
            else if (op == 3)
            {
                Console.WriteLine("Netice: " + (a1 * b1));
            }
            else if (op == 4)
            {
                if (b1 == 0)
                {
                    Console.WriteLine("Deyer 0-a bolune bilmez!");
                }
                else
                {
                    Console.WriteLine("Netice: " + (a1 / b1));
                }
            }




            Console.WriteLine("adiniz nedir?");
            string digito = Console.ReadLine();

            if (digito == "Ehmed")
            {
                Console.WriteLine("Ehmedin 15 yasi var");
            }

            Console.WriteLine("qardasivin adi nedir?");
            string qardas = Console.ReadLine();

            if (qardas == "Valeh")
            {
                Console.WriteLine("Valehin 13 yasi var");
            }
        }
    }
}
