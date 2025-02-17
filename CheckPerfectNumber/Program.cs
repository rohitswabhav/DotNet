using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CheckPerfectNumber
{
    internal class Program
        
    {
        public const int DIVISOR = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check: ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckForPerfectNumber(inputNumber));
        }

        static string CheckForPerfectNumber(int inputNumber)
        {
            int sum = 0;
            int checker = 0;
           
            while(checker <= inputNumber/DIVISOR)
            {
                sum = sum + checker;
                checker++;
            }
            if(sum == inputNumber)
            {
                return "Number is a Perfect Number";
            }
            return "Number is not a Perfect Number";

        }
       
    }
}
