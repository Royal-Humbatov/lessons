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


            #region Task



            string value = Console.ReadLine();
            int point = Convert.ToInt32(value);


            if (point < 0 || point > 100)
            {
                Console.WriteLine("Duzgun bal daxil edilmeyib!");

            }
            else if (point < 20)
            {
                Console.WriteLine("Imtahandan kesildiniz");
                Console.WriteLine("Dogrudur");
            }
            else if (point >= 20 && point < 40) 
            {
                Console.WriteLine("Neticeden kecdiniz");
            }
            else if ( point >=40  && point < 60)
            {
                Console.WriteLine("Netice Kafi");
            }
            else if (point >= 60 &&  point < 80)
            {
                Console.WriteLine("Netice Yaxsi");
            }
            else if (point >= 80 )
            {
                Console.WriteLine("Ela");
            }

            Console.ReadLine();


            #endregion

            Console.WriteLine("Etmek istediyniz emeliyyat sisteminin secin:");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2. Cixma");
            Console.WriteLine("3.Bolme");
            Console.WriteLine("4 Vurma");

            Console.Clear();

            #region task 2
            string country = "USA";

            switch (country)
            {
                case "Brazil":
                    Console.WriteLine("Yalnisdir");
                    break;

                case "USA": 
                    Console.WriteLine("Duzgundur");
                    break;

                default:
                    Console.WriteLine("Hec biri uygun deyil");
                    break;

            }



            #endregion


            #region task 2

            int red = 1;
             
            
            switch (red)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
            }

            #endregion

        }
    }
}
