using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Ən az bir Operand lazımdır
              1. Unary: a++, b--, !true
              2. Binary: a + b, a > b, a = b
              3. Ternary: a > b ? "" : "" (shorthand if else)
              Operator nədir?: +, -, *, !, !=
              Operand nədir?: a, b, c (dəyişənlər və s.)

              1. Arithmetic (hesablama)      ++, --, +, -, *, /, %
              2. Logical (məntiqi)           !, ||, &&
              3. Special (xüsusi)            sizeof, typeof, new, checked, unchecked, as, is
              4. Assignment (mənimsəmə)      =, +=, -=, /=, *=, %=
              5. Comparsion (qarşılaşdırma)  >, <, ==, !=, <=, >=
            */

            decimal x = 100;
            decimal y = 5;
            decimal i = 0;

            //Arithmetic(hesablama)
            i = x + y;
            i = x - y;
            i--; //(i = i - 1);
            i++; //(i = i + 1);
            i = i - 1;
            i = i + 1;
            i -= 5; //(i bərabərdir i çıx 5)
            i += 5; //(i bərabərdir i üstəgəl 5)
            i = x--; //(x-dən 1 çıx, i-yə mənimsət. x'in də dəyəri azalmış olur)
            i = y * 5;
            i = y / 5; //(cavab 5.1, 5.5 və ya 5.9 belə olsa, əgər bölən və bölünən int tipindədirsə cavab 5 olacaq.)
            i = x * y;
            i = x / y;
            i = x % y; //(mod)
            int m = 10 % 2;
            m = 11 % 2;
            string country = "Azerbaijan";
            string city = "Baku";
            string address = country + " və " + city;



            //Logical (məntiqi)
            bool trueBool = true;
            bool falseBool = false;
            bool res;

            res = !trueBool;
            res = !falseBool;
            res = !falseBool || !trueBool;
            res = !falseBool && !trueBool;
            res = 5 == 5;


            //Assignment (mənimsəmə) - (bir dəyişənə dəyər mənimsətmək üçün istifadə olunur)
            int reqem = 100;
            reqem += 5; //(assign = assign + 5;)
            reqem -= 5; //(assign = assign - 5;)
            reqem /= 5; //(assign = assign / 5;)
            reqem *= 5; //(assign = assign * 5;)
            reqem %= 2; //(assign = assign % 5;)
            string person = "Orkhan Farajov";
            person += " is developer";



            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 5;
            string name1 = "Orkhan";
            string name2 = "John";

            bool compareRes = false;
            compareRes = c > d;
            compareRes = c < d;
            compareRes = c == d;
            compareRes = c != d;
            compareRes = c <= d;
            compareRes = c >= d;
            compareRes = name1 == name2;
            //compareRes = name1 == c; //(string və int tipində operandlar qarşılaşdırıla bilməz)
            res = (10 / 2) == 5;
            res = (10 / 2) != 5;



            //Special (xüsusi) sizeof, typeof, new, checked, unchecked, as, is
            int sizeOfSbyte = sizeof(sbyte); //1 byte
            int sizeOfByte = sizeof(byte); //1 byte (byte özü elə 1 byte yer tutur 8 bitdir)
            int sizeOfInt16 = sizeof(Int16); //2 byte
            int sizeOfShort = sizeof(short); //2 byte
            int sizeOfInt32 = sizeof(Int32); //4 byte
            int sizeOfInt = sizeof(int); //4 byte
            int sizeOfInt64 = sizeof(Int64); //8 byte
            int sizeOfLong = sizeof(long); //8 byte
            int sizeOfULong = sizeof(ulong); //8 byte
            int sizeOfUInt = sizeof(uint); //4 byte
            int sizeOfBool = sizeof(bool); //1 byte
            //int sizeOfString = sizeof(string); //(xəta)

            Type type1 = typeof(int);
            Type type2 = typeof(Int32);
            bool compareIntAndInt32 = type1 == type2;

            Type type3 = typeof(int);
            Type type4 = typeof(bool);
            bool compareIntAndBool = type3 == type4;

            DateTime dt = new DateTime();

            //is
            int otherInt = 25;
            bool isOtherInt_String = otherInt is string; //false
            bool isOtherInt_Int = otherInt is int; //true
            bool isOtherInt_Int32 = otherInt is Int32; //true
            bool isOtherInt_Int64 = otherInt is Int64; //false

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string; //(null)
            string sText = objectNum as string;
            //int aaa = sName as int; //(xəta)

            //10 + 20 * 5
            float u = 10 + 20 * 5; //110
            float u1 = (10 + 20) * 5; //150
        }
    }
}
