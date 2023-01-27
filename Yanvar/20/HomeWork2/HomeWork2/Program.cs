using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Homework 2:

                
               Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız. Bu məlumatlar ad, soyad, cins, doğum tarixi,
               yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

               İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
               Ad: Mark
               Soyad: Henry
               Cins: K və ya Q
               Doğum tarixi: 1990-10-10
               Yaşadığı ölkə: Azərbaycan
               Yaşadığı şəhər: Bakı
               Boy: 1.75
               Çəki: 26.50
               Maaş: 2500.00


               */


            string name, surname, gender, birthday, country, city, height, weight, salary;

            #region Sorgu;
            Console.WriteLine("Salam xos geldiniz!");

            Console.WriteLine("Adinizi daxil edin.");
            name = Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin.");
            surname = Console.ReadLine();

            Console.WriteLine("Cinsinizi daxil edin.");
            gender = Console.ReadLine();

            Console.WriteLine("Dogum gununuzu daxil edin.");
            birthday = Console.ReadLine();

            Console.WriteLine("Yasadiginiz olke daxil edin.");
            country = Console.ReadLine();

            Console.WriteLine("Yasadiginiz seher daxil edin.");
            city = Console.ReadLine();

            Console.WriteLine("Boyunuzu daxil edin.");
            height = Console.ReadLine();

            Console.WriteLine("Cekinizi daxil edin.");
            weight = Console.ReadLine();

            Console.WriteLine("Maasinizi daxil edin.");
            salary = Console.ReadLine();
            #endregion


            #region Conversions
            char gender1 = Convert.ToChar(gender);

            DateTime dateValue = Convert.ToDateTime(birthday);


            double doubleVar = Convert.ToInt64(height);

            double doubleVar2 = Convert.ToInt64(weight);

            short shortVar = Convert.ToInt16(salary);

            Console.ReadLine();

            #endregion



        }
    }
}
