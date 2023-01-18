using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Homework 1:
           İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.

           Homework 2:
           İstifadəçidən 10 ədəd şəhər adı daxil etməsini istəyin. İstifadəçi 10 - cu şəhər adını daxil etdikdən sonra sıra ilə şəhər adlarını alt-alta ekrana yazdırın.
           Məsələn:
          Bakı 
          Gəncə
          Sumqayıt

           Homework 3:
           Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 10 - cu şəhərin adını daxil edəndən sonra bu dəfə alt-alta yox vergüllə ayırıb yazın.
           Məsələn: Baki, Gence, Sumqayit

          Qeyd: Bu 3 tapşırığı etmək üçün 3 ayrı yeni Console Application yaradın.Eyni solution içində yazmayın.

           */

            Console.WriteLine("10 eded seher daxil edin:");

            string city1, city2, city3, city4, city5, city6, city7, city8, city9, city10;


            city1 = Console.ReadLine();
            city2 = Console.ReadLine();
            city3 = Console.ReadLine();
            city4 = Console.ReadLine();
            city5 = Console.ReadLine();
            city6 = Console.ReadLine();
            city7 = Console.ReadLine();
            city8 = Console.ReadLine();
            city9 = Console.ReadLine();
            city10 = Console.ReadLine();


            Console.WriteLine(city1 + ", " + city2 + ", " + city3 + ", " + city4 + ", " + city5 + ", " + city6 + ", " + city7 + ", " + city8 + ", " + city9 + ", " + city10 +".");
            Console.ReadLine();
        }
    }
}
