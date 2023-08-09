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
              Homework:
              Person class'ında Id, Name, Surname, Age property'ləriniz olsun. Student class'ında da ClassName (yəni sinif adı)
              TeacherName property'ləri olacaq. Student class'ı da Person class'ından miras alacaq.


              Person class'ında Id, Name, Surname property'lərinin dəyərini ekrana yazdıran ShowInfo() adlı virtual void method'unuz
              olsun. Student class'ında da bu method'u override edib, ClassName və TeacherName property'lərini də ekrana yazdırın.
             */


            Person ps = new Person();
            ps.ID = 1;
            ps.Name = "Royal";
            ps.Surname = "Humbetov";
            ps.Age = 21;
            ps.ShowInfo();


            Student st = new Student();
            st.ID = 2;
            st.Name = "Xeyal";
            st.Surname = "Humbetli";
            st.Age = 17;
            st.ClassName = "9A";
            st.TeacherName = "Ehmed";

            st.ShowInfo();
            
        }
    }
}
