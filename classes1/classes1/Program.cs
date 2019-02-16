using classes1.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";

            john.introduce();

            var cal1 = new Calculator();
            var result = cal1.add(1, 4);
            System.Console.WriteLine(result);
        }
    }
}
