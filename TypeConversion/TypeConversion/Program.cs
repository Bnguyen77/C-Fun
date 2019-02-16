using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert implicit type
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //convert explicit type (num cant be more than byte type limit (0 - 255))
            int num = 1;
            byte val = (byte)num;
            Console.WriteLine(val);

            //convert non-convertable type
            var number = "12345";
            //int value = (int)number; ==> this will not work
            int value = Convert.ToInt32(number);
            Console.WriteLine(value);
        }
    }
}
