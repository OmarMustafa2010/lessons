using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case

            string langOrFramework = "C#";

            switch (langOrFramework)
            {
                case "ASP.NET":
                    Console.WriteLine("langOrFramework deyisenin deyeri ASP.NET sozudur");
                    break;

                case "F#":
                    Console.WriteLine("langOrFramework deyisenin deyeri F# sozudur");
                    break;

                case "C#":
                    Console.WriteLine("langOrFramework deyisenin deyeri C# sozudur");
                    break;

                case "Java":
                    Console.WriteLine("langOrFramework deyisenin deyeri Java sozudur");
                    break;

                default: //(eger hec bir case'e girmese)
                    Console.WriteLine("Hec birine uygun gelmedi");
                    break;
            }



            if (langOrFramework == "ASP.NET")
            {
                Console.WriteLine("langOrFramework deyisenin deyeri ASP.NET sozudur");
            }
            else if (langOrFramework == "F#")
            {
                Console.WriteLine("langOrFramework deyisenin deyeri F# sozudur");
            }
            else if (langOrFramework == "C#")
            {
                Console.WriteLine("langOrFramework deyisenin deyeri C# sozudur");
            }
            else if (langOrFramework == "Java")
            {
                Console.WriteLine("langOrFramework deyisenin deyeri Java sozudur");
            }
            else
            {
                Console.WriteLine("Hec birine uygun gelmedi");
            }
            #endregion

            #region Task in Lesson 1
            /*
             1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
             2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.
             */
            string strMonth = Console.ReadLine();
            int month = Convert.ToInt32(strMonth);

            switch (month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
            }
            #endregion
        }
    }
}
