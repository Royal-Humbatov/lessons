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
             Homework 1:
             Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
             Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
             Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
             tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
             */

            Console.Write("Telebenin adi: ");
            string name = Console.ReadLine();

            Console.Write("Telebenin soyadi: ");
            string surname=Console.ReadLine();

            Console.Write("1 ci qiymeti daxil et: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2 ci qiymeti daxil edin: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("3 cu qiymeti daxil edin: ");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());

            Student student = new Student();


            decimal ortalama = student.CalcAvarage(number1, number2, number3);
            Console.WriteLine(ortalama);
            student.RateAverage(ortalama);

            Console.ReadLine();
        }

    }
}
