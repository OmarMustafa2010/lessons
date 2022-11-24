using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Syntax of programming language

            #endregion

            #region What is Visual Studio
            //Visual Studio bir IDE'dir
            //Solution Explorer pəncərəsini açmaq üçün CTRL+ALT+L kombinasiyasından istifadə etmək lazımdır.
            #endregion

            #region First C# code
            Console.Write("Hello ");
            Console.Write("World");

            Console.WriteLine("Hello World");

            // System - namespace adı
            // Console - System namespace'inin içində bir class adı
            // Write - Console class'ının içindəkir bir funksiyanın adı
            #endregion

            #region Read user data
            Console.WriteLine("Salam xos gelmisiniz!");
            Console.WriteLine("Adinizi daxil edin:");
            var nameOfUser = Console.ReadLine();

            //var read = Console.Read(); //Read method'u basılan ilk simvolun key kodunu göstərir
            //var readKey = Console.ReadKey(); //ReadKey method'u basılan ilk simvolun keychar kodunu alır
            var readLine = Console.ReadLine(); //ReadLine method'u bütün sətri mətn olaraq götürür.

            var welcomeMsg = "Salam xos gelmisiniz!";
            Console.WriteLine(welcomeMsg);

            var whatIsYourName = "Adiniz nedir?";
            Console.WriteLine(whatIsYourName);
            #endregion


            #region Breakpoint
            Console.WriteLine("Top 1");
            Console.WriteLine("Top 2");
            Console.WriteLine("Top 3");
            Console.WriteLine("Top 4");
            Console.WriteLine("Top 5");
            Console.WriteLine("Top 6");
            Console.WriteLine("Top 7");
            Console.WriteLine("Top 8");
            Console.WriteLine("Top 9");
            Console.WriteLine("Top 10");

            //Breakpoint atdıqdan sonra, yəni debug edən zaman:
            // F10'a düyməsinə basdıqda, olduğun sətirdən sonrakı ilk kod olan sətirə aparır.
            // F5'ə basdıqdan sonra olduğun sətirdən sonrakı bütün kodları oxuyub icra edir.
            // Kodu bir və ya bir neçə əmr geriyə qaytarmaq üçün sarı oxu yuxarı çəkmək lazımdır. Bu həmin kodu təkrar icra edir.
            #endregion

            #region Task in Lesson
            /*
             4 ədəd dəyişənin olacaq.
             1. Red in dəyəri qirmizi
             2. Car ın dəyəri avtomobil
             3. Expensive in dəyəri bahali
             4. Phone un dəyəri telefon.
             qirmizi avtomobil
             bahali telefon
             */
            var red = "qirmizi";
            var car = "avtomobil";
            var expensive = "bahali";
            var phone = "telefon";

            Console.Write(red);
            Console.Write(car);
            Console.WriteLine();
            Console.Write(expensive);
            Console.Write(phone);
            Console.WriteLine(red + " " + car);
            Console.WriteLine(expensive + " " + phone);
            #endregion

            #region Comment and Regions
            //1. Single Line Comment
            Console.Write("Bu kod oxunacaq");
            //2. Multi Line Comment

            /*
             Salam
             necesen
             bura bir
             multi line
             comment hissesidir
             Console.Write("Bu yazi ekrana cixmayacaq cunku bir comment blokunun icinde yazilib!")
             */
            Console.Write("bu kod da oxunacaq");
            #endregion

            Console.ReadLine();
        }
    }
}
