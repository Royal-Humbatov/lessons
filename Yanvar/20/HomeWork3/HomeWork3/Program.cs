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
              Homework 3:

             İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız. Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz. Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).

             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
                
             */

            #region Anket  hissesi
            string age, salary, height, weight, how_freinds;

            Console.WriteLine("Xos Gelmissiniz:");

            Console.WriteLine("Nece yasiniz var?");
            age = Console.ReadLine();

            Console.WriteLine("Masinniz hansidir?");
            salary = Console.ReadLine();

            Console.WriteLine("Boyunuz ne qederdir?");
            height = Console.ReadLine();

            Console.WriteLine("Cekiniz ne qederdir?");
            weight = Console.ReadLine();

            Console.WriteLine("Nece dostunuz var?");
            how_freinds = Console.ReadLine();

            #endregion


            #region Convert Hissesi;
            int ageF, salaryF, heightF, weightF;

             ageF = Convert.ToInt32(age);
             salaryF = Convert.ToInt32(salary);
             heightF = Convert.ToInt32(height);
             weightF = Convert.ToInt32(height);

            byte valueVar = (byte)ageF;
            byte valueVar2 = (byte)salaryF;
            byte valueVar3 = (byte)heightF;
            byte valueVar4 = (byte)weightF; 



            checked
            {
                byte byteVar = (byte)ageF;
                byte byteVar2 = (byte)salaryF; 
            }
            #endregion

        }
    }
}
