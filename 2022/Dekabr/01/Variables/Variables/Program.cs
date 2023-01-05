using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //typeOfVariable nameOfVariable =  valueOfVariable
            //deyiseninTipi  deyiseninAdi   =  deyiseninDeyeri

            Console.WriteLine("Salam xos gelmisiniz.");

            string welcomeMsg = "Salam xos gelmisiniz.";
            Console.WriteLine(welcomeMsg);


            string anotherPerson;

            anotherPerson = "Orkhan Farajov";

            string job = "Programci";

            string name = "Elcin";
            Console.WriteLine(name);

            name = "Ferhad";
            Console.WriteLine(name);

            //Data Type = Melumat tipi
            //Şüşə qabın içinə bir mayeni tökməkdən nümunə versək,
            //Data tipi şüşənin özüdür
            //Data isə, mayedir

            //ədədi həm string olaraq string tipində bir dəyişəndə saxlamaq olar, həm də int tipində
            string oneString = "1";
            int oneInteger = 1;

            //hərfi, mətni isə stringdə saxlamaq olur, ancaq int tipində saxlamaq olmur.
            string aString = "a";
            int aInteger = 2000;

            //Byte hesablama dusturu
            //1 byte = 8 bit

            //Int16 tipi 16 bit'dir. 16 bit / 8 bit = 2 byte
            //Int32 tipi 32 bit'dir. 32 bit / 8 bit = 4 byte
            //Int64 tipi 64 bit'dir. 64 bit / 8 bit = 8 byte

            short a = 5000; //Int16 / 2 byte
            int b = 40000000;  //Int32 / 4 byte
            long c = 9999999999999;//Int64 / 8 byte


            #region Boolean Type
            //true  pozitif
            //false negatif
            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar;
            otherBooleanVar = true;
            #endregion


            #region String Type
            string name_ = "Orkhan";
            Console.WriteLine(name_);

            string surname = "Farajov";
            Console.WriteLine(surname);

            string adSoyad = "Orkhan Farajov";

            string adSoyadBoyukHerfle = adSoyad.ToUpper();

            string adSoyadKicikHerfle = adSoyad.ToLower();

            bool tHerfileBaslayir = adSoyad.StartsWith("t");

            bool endsWith = adSoyad.EndsWith("v");

            int herfSayi = adSoyad.Length;

            Console.WriteLine(adSoyadKicikHerfle);
            #endregion


            #region Short, Int, Long Types
            //həcmi:
            //int16: 2 byte
            //int32: 4 byte
            //int64: 8 byte
            //ala bildiyi dəyər aralığı:
            //int16 bit üçün: −32,768 --- 32,767
            //int32 bit üçün: −2147483648 --- 2147483647
            //int64 bit üçün: −9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807

            short shortMinValue = short.MinValue;
            short shortMaxValue = 32767;
            short shortValue = 18262;
            short shortValueNegative = -1562;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int integer = 2458745;
            int integerValueNegative = -222666;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 8251156626515854958;
            long longValueNegative = -825115615854958;

            string intToString = 555.ToString();
            #endregion
        }
    }
}
