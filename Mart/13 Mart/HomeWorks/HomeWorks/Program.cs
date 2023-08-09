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
            Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
            inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
            City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
            2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
            ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
               ID: 1
               Name: Cavid
               Surname: Cavidov
               Age: 20
               Address Info:
               ID: 100
               No: 10
               Building: Some Building
               Street: Some Street
               City: Some City
               Country: Some Country

               ID: 2
               Name: Hasan
               Surname: Hasanov
               Age: 32
               Address Info:
               ID: 100
               No: 10
               Building: Some Building
               Street: Some Street
               City: Some City
               Country: Some Country

            Homework 2:
            Generic class yaradaraq (Repository) Add, Update, Get, Delete method'larını yazın. Həmin repository'nin instance'ını
            Student, Customer, Teacher və Book class'ları ilə yaradıb hər bir method'u istifadə edə bilməlisiz. GenericRepository
            class'ı üçün İnterface'də istifadə edin.
            */

            #region Task1
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Royal";
            customer.Surname = "Humbetov";
            customer.Age = 21;
           
            

            Address adress = new Address();
            adress.Id = 2;
            adress.No = 25;
            adress.Building = 35;
            adress.Street = 15;
            adress.City = "Baku";
            adress.Country = "Azerbaijan";

            customer.Address = adress;



            List<Customer> customers = new List <Customer>();
            customers.Add(customer);

            customers.ForEach(i => Console.WriteLine(i.Id + " " + i.Name + " " + i.Surname + " " + i.Address.City)); 

            List<int> integers = new List<int>();
            integers.Add(15);
            integers.Add(26);
            
            integers.ForEach(i => Console.WriteLine(i));
            Console.ReadLine();

            #endregion

            #region Task2

            #endregion
        }
    }
}
