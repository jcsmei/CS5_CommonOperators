using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5_CommonOperators
{
    class Program
    {
        static void Main()
        {
            int i = 10;
            bool b = true; // = assignment operator

            int Numerator = 10;
            int Denominator = 2;
            int Answer = Numerator / Denominator;
            Console.WriteLine("10 / 2 = {0}", Answer);

            //comparison operator
            int Number = 10;

            if (Number == 10) {
                Console.WriteLine("true");
            } else {
                Console.WriteLine("false");
            }
            
            if (Numerator == 10 && Denominator == 2)
            {
                int result = Numerator * Denominator;
                Console.WriteLine("10 * 2 = {0}", result);
            } else
            {
                Console.WriteLine("no result");
            }

            int num = 99;
            //bool CheckNum;

            //if (num == 10)
            //{
            //    CheckNum = true;

            //} else
            //{
            //    CheckNum = false;
            //}
            //Console.WriteLine("{0}", CheckNum);

            bool CheckNum = num == 10 ? true : false;
            //ternery operator ?
            //check if num is euqal to 10 then return True else FALSE
            Console.WriteLine("{0}", CheckNum);

            Console.ReadLine();
        }
    }
}
