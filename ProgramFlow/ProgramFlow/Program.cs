using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static int getGuess()
        {
            int result = 0;
            Console.WriteLine("guess the number");
            String answer = Console.ReadLine();
            Int32.TryParse(answer, out result);
            return result;
        }
        static void Main(string[] args)
        {
            const int ournumber = 10;
            int guessnumber = 0;

            for (int n =20;n > 0; n--)
            {
                guessnumber = getGuess();
                switch (guessnumber)
                {
                    case (ournumber):
                        Console.WriteLine("the answer is correct YAYY");
                        n = 0;
                        break;
                    case (1):
                        Console.WriteLine("1 is too low man, guess left {0}", n - 1);
                        break;
                    case (20):
                        Console.WriteLine("20 is a bit too high, guess left {0}", n - 1);
                        break;
                    case (100):
                        Console.WriteLine("100 is WAY too high, guess left {0}", n - 1);
                        break;
                    default:
                        if (guessnumber > ournumber)
                        {
                            Console.WriteLine("number is too high, guess left {0}", n - 1);
                        }
                        else if (guessnumber < ournumber)
                        {
                            Console.WriteLine("number is too low guess left {0}", n - 1);
                        }
                        break;
                }
              
            }


            //while(ournumber != guessnumber)
            //{
            //    guessnumber = getGuess();
            //    if (guessnumber == ournumber)
            //    {
            //        Console.WriteLine("the answer is correct");
            //    }
            //    else if (guessnumber > ournumber)
            //    {
            //        Console.WriteLine("number is too high");
            //    }
            //    else if (guessnumber < ournumber)
            //    {
            //        Console.WriteLine("number is too low");
            //    }
            //}


            Console.WriteLine("press keys to exit");
            Console.ReadLine();
        }
    }
}
