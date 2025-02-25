using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char gender = 'M';
            int i = 97;
            char c = (char)i; //Explicit Conversion
            //float j = float.Parse(gender);
            //long l = i;
            //double d = i;
            //Console.WriteLine(c);
            // Console.WriteLine(" " + i + " " + j + " " + l + " "+ d);

            // char -> int -> long -> float -> double {Implicit TypeCasting} cannot go backwards
            //if we go backwards we do it forcefully

            int d = 97;
            int num = 23;
            //char c2 = (char)d;
            //Console.WriteLine(c2);
            char c4 = Convert.ToChar(num);
            char c3 = Convert.ToChar(d);
            Console.WriteLine(c3);

        }
    }
}
