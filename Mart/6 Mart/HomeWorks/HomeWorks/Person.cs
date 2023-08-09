using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
   public class Person : Base
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; } 

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID: " + ID + "Name: " + Name + "Surname: " + Surname + "Age: " + Age);
        }

        public override void Get(int id)
        {
            Console.WriteLine();
        }
    }
}
