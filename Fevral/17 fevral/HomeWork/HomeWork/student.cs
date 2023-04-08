using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
     public  class Student
    {
        private string Ad;
        private string Soyad;
        private string Email;



        public string Name {
            get
            {
                return this.Ad;
            }

            set
            {
                this.Ad = value;
                if (Soyad != null)
                {
                    this.Email = string.Format(Ad.ToLower(), Soyad.ToLower());
                }
            }
        }

        public string Surname
        {
            get
            {

            }

            set
            {

            }
        }
    }
}
