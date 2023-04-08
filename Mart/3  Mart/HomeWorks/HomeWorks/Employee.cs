using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
   public class Employee : Person
    {
        public DateTime DateStartWorking { get; set; }
        public DateTime DateEndWorking { get; set; }
        public string RestDays { get; set; }

    }
}
