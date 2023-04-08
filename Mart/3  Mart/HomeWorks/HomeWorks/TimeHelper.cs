using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    public class TimeHelper
    {
        public static void GetCurrentTime()
        {
            Console.WriteLine(DateTime.Now); 
        }

        public void SetComputerTime()
        {
            Console.WriteLine("Saat deyisdirildi");
            GetCurrentTime();
        }
    }
}
