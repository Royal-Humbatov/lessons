using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             5 dənə dəyişəni Implicit Conversion,
             5 dənə dəyişəni Explicit Conversion,
             5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.
             */

            #region Implicit Conversion;
            //1
            byte byteValue = byte.MaxValue;

            short shortValue2 = byteValue;

            //2

            short shortValueVar = short.MaxValue;
            int intValue = int.MaxValue;

            int intValue2 = shortValueVar;

            //3

            int intValueVar = int.MaxValue;
            long longValue = long.MaxValue;

            long longValue2 = intValueVar;

            //4 

            long longValueVar = long.MaxValue;
            float floatValue = float.MaxValue;

            float floatValueVar = longValueVar;

            //5

            float floatValue2 = float.MaxValue;
            double doublelValue = double.MaxValue;

            double doubleVar = floatValue2;


            #endregion

            #region Explicit Conversion;

            //1;

            short a = 30235;
            byte b = (byte) a;

            //2;

            int c = 549651686;
            short d = (short) c;

            //3;

            long e = 659854168752546;
            int f = (int) e;

            //4;

            char g = 'A';
            byte h = (byte) g;

            //5;

            char l = '?';
            short n = (short) l;

            #endregion

            #region Helper Class Conversion;
            //1;

            string toString = "56";
            short toShort = Convert.ToInt16(toString);

            //2;

            bool toBoolen = true;
            string toString2 = Convert.ToString(toBoolen);

            //3;

            bool toBool = true;
            short toShort3 = Convert.ToInt16(toBool);


            //4;

            string toString3 = "Hello!";
            long toLong = Convert.ToInt64(toString);

            //5;

            bool toBoolen3 = false;
            int toInt = Convert.ToInt32(toBoolen3);
            #endregion



        }
    }
}
