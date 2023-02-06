using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    class Student
    {
        
        
      
        /*
            Homework 1:
            Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
            Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
            Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
            tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
        */


         public decimal CalcAvarage(decimal number1, decimal number2,  decimal number3)
        {
            Console.WriteLine("Ortalamani hesabla");
            decimal avarage = (number1 + number2 + number3) /3;
            return avarage;

        }
         


         public void RateAverage(decimal value) 
        {
            

            if (value>45)
            {
                Console.WriteLine("Kecib");
            }
            else
            {
                Console.WriteLine("Kesilib");
            }
        }
       
    }
}
