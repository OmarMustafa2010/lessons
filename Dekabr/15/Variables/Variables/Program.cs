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

            short a1 = 5000; //Int16 / 2 byte
            int b1 = 40000000;  //Int32 / 4 byte
            long c1 = 9999999999999;//Int64 / 8 byte


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


            #region Char Type
            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";
            string g = "G";
            string h = "H";

            char charA = 'A';
            char charB = 'B';
            char charC = 'C';
            char charD = 'D';
            char charE = 'E';
            char charF = 'F';
            char charG = 'G';
            char charH = 'H';

            char symbol = '*';
            char whiteSpace = ' ';
            char question = '?';

            char toLower = char.ToLower(charA);
            char toUpper = char.ToUpper(charA);

            bool isLower = char.IsLower(charA);
            bool isUpper = char.IsUpper(charA);

            bool isNumber = char.IsNumber(charA);
            bool isLetter = char.IsLetter(charA);
            bool isDigit = char.IsDigit(charA);
            bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            #endregion


            #region Byte Type
            byte byteVariable = 45;
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            #endregion

            byte myByteVariable = 250; //1 byte yer tutur
            short myShortVariable = 30000; //2 byte yer tutur
            int myIntVariable = 3000000; //4 byte yer tutur

            long myLongVariable = 2; //Ramda 8 byte yer tutdu
            long otherLongVariable = 2519545945415919159; //Ramda 8 byte yer tutdu

            #region Double Type
            double doubleVar = 10.2;
            double doubleVar2 = 25;
            double doubleVar3 = 45.8d;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;
            #endregion


            #region Task in Lesson 1
            /*
             5 dənə dəyişəniniz olacaq. Mən dəyərlərini verəcəm siz də o dəyərlər əsasında dəyişənin tiplərini təyin edəcəksiz.
                1. Birinci dəyişənə true dəyərini,
                2. İkinci dəyişənə tək dırnaq arasında 'A' hərfini,
                3. Üçüncü dəyişənə RAM'ı nəzərə almaqla 5 rəqəmini,
                4. Dördüncü dəyişənə cüt dırnaq içində Salam sözünü,
                5. Beşinciyə isə 18 dənə 9 rəqəmini verməlisiniz. Trilyondan çox edir.
             */
            bool myBooleanVariable = true;
            char mycharVariable = 'A';
            byte myByte = 5;
            string hello = "Salam";
            long myLong = 999999999999999999;
            #endregion


            #region Decimal Type
            decimal decimalVar = 15.7m;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            //byte decimalToByte = decimal.ToByte(10000000);
            //sbyte decimalToByte = decimal.ToSByte(10000000);

            //basqa numuneler
            short decimalToShort = decimal.ToInt16(500);
            int decimalToInt = decimal.ToInt32(222515);
            long decimalToLong = decimal.ToInt64(845615615615651);
            #endregion


            #region Float Type
            float floatVar = 10.4f;

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            #endregion

            float f3 = 11.4f; //4 byte
            double d1 = 10.9; //8 byte
            decimal d2 = 14.7m; //16 byte



            #region DateTime Type
            DateTime now = DateTime.Now; //Local saatı götürür
            DateTime utcNow = DateTime.UtcNow;

            DateTime specialDate = new DateTime(1990, 12, 25);
            DateTime specialDate2 = new DateTime(1990, 12, 25, 10, 05, 59, 350);
            #endregion
        }
    }
}
