﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
   public class Student : Person
    {
        public string ClassName { get; set; }
        public string TeacherName { get; set; }


        public override void ShowInfo()
        {
           base.ShowInfo();
        }

    }

}
