using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";


        static void Main(string[] args)
        {
            Console.WriteLine("salam xos gelmisiniz");

            byte number = 52;
            sbyte number1 = -5;

            int many = 180000;
            long l = 99525151515548141;

            double d1 = 25.8;
            decimal money = 14.5m;
            float myFloatVariable = 47.8f;

            bool check = true;

            string name = "Orxan";
            string surname = "Ferecov";
            int age = 28;

            Console.WriteLine(name + " " + surname);


            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.Clear();


            #region Object Type
            object stringVar = "My string";
            object intVar = 55;
            object boolVar = true;
            object charVar = 'u';
            object dateTimeVar = DateTime.Now;

            Console.WriteLine(stringVar);
            Console.WriteLine(intVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);
            Console.WriteLine(dateTimeVar);
            #endregion







            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";
            Console.WriteLine(orkhan); //Orkhan Farajov

            orkhan = john;
            Console.WriteLine(orkhan); //John Farajov

            orkhan = "hello";
            Console.WriteLine(orkhan);  //Hello

            john = "hi";


            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false; //Eger isti iqlimli olke ucundurse deyeri sonradan deyisdirile biler

            char p = 'P';
            char pCopied = p;
            #endregion







            #region Default Values of data types
            //referance types
            string defaultString;
            object defaultObject;
            Student defaultStudentClass;

            //value types
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLong;
            decimal defaultDecimal;
            double defaultDouble;
            float defaultFloat;
            bool defaultBool;
            DateTime defaultDateTime; //ilk 01.01.0001
            #endregion






            Console.Clear();





            #region Local vs Global Variables
            Console.WriteLine(Country);

            ShowCountry();

            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);

            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }

            Console.WriteLine(globalVar);


            //Level 5 - Bütün skoplara görə global və əl çatan (Main skopu içində)
            int level5 = 500;
            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level3 does not exist
            //level2 -= 100; //level2 does not exist
            //level1 -= 100; //level1 does not exist
            {
                //Level 4 - Alt skoplara görə global, üst skoplara görə local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level3 does not exist
                //level2 -= 100; //level2 does not exist
                //level1 -= 100; //level1 does not exist
                {
                    //Level 3 - Alt skoplara görə global, üst skoplara görə local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level2 does not exist
                    //level1 -= 100; //level1 does not exist

                    {
                        //Level 2 - Alt skoplara görə global, üst skoplara görə local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level1 does not exist
                        {
                            //Level 1 - tamamilə local dəyişən
                            int level1 = 100;

                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
            }


            int globalAge;

            {
                int localAge = 65;
                globalAge = localAge;
            }

            {
                Console.WriteLine(globalAge);
            }

            #endregion

            Console.ReadLine();
        }


        public static void ShowCountry()
        {
            Console.WriteLine(Country);
            //Console.WriteLine(myLocalVariable); xeta
        }
    }
}
