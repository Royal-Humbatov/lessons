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
            Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
            Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
            Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.


            Homework 2:
            Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
            və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
            istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
            */




            const string userName = "admin";
            const string password = "admin";

            Console.WriteLine("Zehmet olmazsa username ve sifreni daxil edin!");

            Console.Write("Adiniz daxil edin ");
            string enteredUserName = Console.ReadLine();

            Console.Write("Sifreni daxil edin ");
            string enterEdPassword = Console.ReadLine();

            if ( enteredUserName==userName && enterEdPassword==password )
            {
                Console.WriteLine("Sisteme daxil olundu");
            }

            

            else 
            {
              
                Console.WriteLine("Yeniden username ve password daxil edin.");

                Console.Write("Adiniz daxil edin ");
                enteredUserName = Console.ReadLine();

                Console.Write("Sifreni daxil edin ");
                enterEdPassword = Console.ReadLine();

                if (enteredUserName == userName && enterEdPassword == password)
                {
                    Console.WriteLine("Sisteme daxil olundu");
                }

                else
                {
                   
                    Console.WriteLine("Yeniden username ve password daxil edin.");

                    Console.Write("Adiniz daxil edin ");
                    enteredUserName = Console.ReadLine();

                    Console.Write("Sifreni daxil edin ");
                    enterEdPassword = Console.ReadLine();

                    if (enteredUserName == userName && enterEdPassword == password)
                    {
                        Console.WriteLine("Sisteme daxil olundu");
                    }
                    else
                    {
                        Console.WriteLine("Hesab Bloklandi");
                    }
                }

            }

            Console.ReadLine();


          



        }
    }
}
