using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //Boxing
            //Implicit
            int valueType = 100; //Stack'da saxlanilir
            object referanceType = valueType;

            //Explicit
            object otherRefType = (object)valueType;



            //Unboxing
            int a = 100;
            object o = a;

            int unboxing = (int)o;
            #endregion


            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with Convert
            int convertToInt = Convert.ToInt32(textNumber);

            //with parse method
            int parsetoInt = int.Parse(textNumber);

            //with tryParse method
            int integerValue;

            string notNumberString = "5Salam";
            bool badResult = int.TryParse(notNumberString, out integerValue);

            string numberString = "5";
            bool goodResult = int.TryParse(numberString, out integerValue);
            #endregion


            #region Task in Lesson 1
            /*
              Bir bool tipində dəyişənin olacaq dəyəri də true olacaq. Bir dənə də int tipində dəyişən yaradıb, dəyərini 1 olaraq ver.
              Bu int dəyişəninə dəyəri 1 verəndən sonra, elə etməlisən ki, boolean tipində dəyişəni necəsə konvertasiya edib 0 dəyərini əldə
              edəsən. Convert, Parse və ya TryParse'dan istifadə etməlisən.
             */
            bool booleanVar = true;
            string stringVar = Convert.ToString(booleanVar);
            int resultOfTryParse = 1;

            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            int result = Convert.ToInt32(parse);
            #endregion



            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //default deyeri qaytaracaq
            //int nullParseResult = int.Parse(nullString); //xeta

            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal);


            string notIntString = "A";
            //int notIntConvertResult = Convert.ToInt32(notIntString); //xeta
            //int notIntParseResult = int.Parse(notIntString); //xeta

            int notIntOutVal = 2;
            bool tryToParseNotInt = int.TryParse(notIntString, out notIntOutVal);




            #region Task in Lesson 2
            /*
             Task 1: İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq. Sonra bu iki int tipindən
                     başqa boolean tipində 2 dəyişəniniz olacaq. Bu iki int tipində olan dəyişəninizi digər iki boolean tipində dəyişənə
                     çevirəcəksiz.
             */
            int falseVal = 0;
            int trueVal = 1;

            bool trueBool = Convert.ToBoolean(trueVal);
            bool falseBool = Convert.ToBoolean(falseVal);


            /*
             Task 2: Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni bir başqa object tipindəki
                     dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində 3-cü bir dəyişən yaradın və 2-ci yaratdığınız object'in
                     dəyərini 3-cü yaratdığınız DateTime tipində olan dəyişənə verin.
             */

            DateTime now = DateTime.Now;
            object objDate = now;
            DateTime dateFromObject = Convert.ToDateTime(objDate);


            /*
              Task 3: İki string tipində dəyişəndə True və False sözlərini saxla. Sonra bu string'ləri bool tipində bir dəyişənə çevir.
                      Convert'dən istifadə etmək olmaz.
             */
            string trueText = "True";
            string falseText = "False";

            bool trueFromText = bool.Parse(trueText);
            bool falseFromText = bool.Parse(falseText);
            #endregion



            #region Constant
            double pi = 3.14;
            //bir ay kecdi...
            pi = 5.20;


            const double piConst = 3.14;
            //piConst = 5.20;



            int no; //burada teyin etdim
            no = 100; //deyerini burda teyin ede bilirem
            
            decimal dec;
            dec = 45.5M;

            string name;
            name = "Orkhan";

            DateTime dt;
            dt = DateTime.Now;

            //const int aa; //deyer vermeden teyin etmek olmaz
            const int number = 600; //deyeri set edilmelidir

            //const int buildingNo = no; //(const, ancaq const deyer qebul edir)
            #endregion


            #region Var
            int numberOne = 1;
            string text = "Hello";
            decimal decim = 45.3M;
            double dob = 100.20D;
            DateTime date = DateTime.Now;
            char ch = '%';
            long l = 515615615615616;
            short s = 15;

            var numberOneVar = 1;
            var textVar = "Hello";
            var decimVar = 45.3M;
            var dobVar = 100.20D;
            var dateVar = DateTime.Now;
            var chVar = '%';
            var lVar = 515615615615616;
            var sVar = 15;

            var i = 100;
            //i = "salam";

            var dbl = 45.5D;
            //dbl = true;

            object objectVariable = 1;
            objectVariable = "Test";
            objectVariable = true;
            objectVariable = '#';
            objectVariable = DateTime.Now;

            int seeIntMethods = 5;
            string seeStringMethods = "salam";
            object obj = seeIntMethods;
            object obj1 = seeStringMethods;

            int number1, number2, otherNumber;

            string name1, surname, fatherName, birthPlace;

            DateTime startDate, endDate;

            int no1 = 20, no2 = 30, no3 = 40;

            string firstname = "Orkhan", lastname = "Farajov", color = "white";
            #endregion
        }
    }
}
