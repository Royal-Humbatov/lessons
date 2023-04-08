using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
   public class Base
    {
        public int Id { get; set; }
        public int RegUser { get; set; }
        public DateTime RegDate { get; set; }
        public int EditUser { get; set; }
        public DateTime EditDate { get; set; }
        public string Deleted { get; set; }
    } 
}
