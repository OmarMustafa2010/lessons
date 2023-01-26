using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            // if(sert){
            //     if serti odendiyi zaman ise dusecek kodlar
            // }else{
            //     if serti odenmediyi zaman ise dusecek kodlar
            // }
            // */

            //int age = Convert.ToInt32(Console.ReadLine());

            ////(Sadece if sertile)
            //if(age <= 18)
            //{
            //    Console.WriteLine("Yeniyetme genc");
            //}

            //if(age > 18)
            //{
            //    Console.WriteLine("Yetiskin");
            //}

            ////(if else ile)
            //if (age <= 18)
            //{
            //    Console.WriteLine("Yeniyetme genc");
            //}
            //else
            //{
            //    Console.WriteLine("Yetiskin");
            //}

            ////(skop'suz if else)
            //if (age <= 18)
            //    Console.WriteLine("Yeniyetme genc");
            //else
            //    Console.WriteLine("Yetiskin");



            //Console.Clear();


            //Console.WriteLine("Adinizi daxil edin: ");
            //string name = Console.ReadLine();

            //if(name == "orkhan")
            //{
            //    Console.WriteLine("name deyeri orkhan'dir.");
            //}
            //else
            //{
            //    Console.WriteLine("name deyeri orkhan deyil.");
            //}


            //bool result = (name == "orkhan");

            //if (result)
            //{
            //    Console.WriteLine("Salam");
            //    Console.WriteLine("name deyeri orkhan'dir.");
            //    Console.WriteLine("Sagol");
            //}
            //else
            //{
            //    Console.WriteLine("Salam");
            //    Console.WriteLine("name deyeri orkhan deyil.");
            //    Console.WriteLine("Sagol");
            //}


            int a = 10;
            int b = 20;

            if (a > 5 && b < 25)
            {
                Console.WriteLine("a deyeri 5-den boyukdur, b deyeri 25-den kicikdir");
            }



            string country = "Azerbaycan";

            if(country == "Turkiye")
            {
                Console.WriteLine("Turkiyenin paytaxti Ankara seheridir.");
            }
            else if(country == "Almaniya")
            {
                Console.WriteLine("Almaniyanin paytaxti Berlin seheridir.");
            }
            else if (country == "Italiya")
            {
                Console.WriteLine("Italiyanin paytaxti Roma seheridir.");
            }
            else if (country == "Azerbaycan")
            {
                Console.WriteLine("Azerbaycanin paytaxti Baki seheridir.");
            }
            else if (country == "Fransa")
            {
                Console.WriteLine("Fransanin paytaxti Paris seheridir.");
            }
            else if (country == "Hollandiya")
            {
                Console.WriteLine("Hollandiyanin paytaxti Amsterdam seheridir.");
            }
            else
            {
                Console.WriteLine("Hec bir sert temin edilmedi!");
            }

            /*
             Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0-dan
                   kiçik, 100-dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın. Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.
                       
                   Bal 20-dən kiçik olarsa "İmtahandan kəsildiniz" yazın.
                   20-dən böyük və ya bərabər, 40-dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"
                   40-dan böyük və ya bərabər, 60-dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"
                   60-dan böyük və ya bərabər, 80-dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"
                   80-a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
             */

            Console.ReadLine();
        }
    }
}
