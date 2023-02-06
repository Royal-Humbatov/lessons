using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                      b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.

            Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
                        çıxma, vurma və bölmə üçün də edin.

            Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil
                        edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.

            Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. bool, string, short, long, int, char, datetime.
            */


            #region HomeWork1;

            int a = 20;
            int b = 50;

            a = a + b;
            b = a - b;
            a = a - b;

            #endregion

            int number = 0;
            int number2 = 0;
            int number3 = 0;


            #region HomeWork2;
            Console.WriteLine("1 ci reqemi daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci reqemi daxil, edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 cu reqemi daxil edin:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            number = num1 + num2 + num3;
            number2 = num1 - num2 - num3;
           

            Console.WriteLine("Netice:" + num1 + "+" + num2 + "+" + num3 + "=" + number );
            Console.WriteLine("Netice:" + num1 + "-" + num2 + "-" + num3+ "="+ number2);

            Console.ReadLine();


            #endregion

            #region HomeWork4;

            Console.Write("Bool deyerini daxil edin");
            bool toBool = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("String deyerini daxil edin");
            string toString = Convert.ToString(Console.ReadLine());

            Console.WriteLine("short deyerini daxil edin");
            short toShort = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Long deyerini daxil edin"); 
            long toLong = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("int deyerini daxil edin");
            int toInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Char deyerini daxil edin");
            char toChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Datetime daxil edin");
            DateTime toTime = Convert.ToDateTime(Console.ReadLine());

            Console.ReadLine();

            Console.Clear();
            #endregion



        }
    }
}
