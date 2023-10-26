using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sample input = 123, Sample output = 321
            //Sample input = -123, sample output = -321
            //Sample input = 1534236469, sample output = 0

            int inputNumber = 120;
            int reverseNumber = Reverse(inputNumber);
            Console.WriteLine(reverseNumber);
            Console.ReadKey();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            long reverseNumber = 0;
            int modNumber = 0;

            while(x != 0)
            {
                modNumber = x % 10;
                reverseNumber = reverseNumber * 10 + modNumber;
                x = x / 10;
            }

            if(reverseNumber > int.MaxValue || reverseNumber < int.MinValue)
            {
                reverseNumber = 0;
            }

            return (int)reverseNumber;
        }
    }
}
