using System;
using System.Collections;

namespace RomanToInteger
{
    public class Program
    {
   
        public static int RomanToInt(string s)
        {
            //Set numerical value against roman number
            //Store in Hashtable for faster retrival
            Hashtable hashTable = new Hashtable();
            hashTable.Add("I", 1);
            hashTable.Add("V", 5);
            hashTable.Add("X", 10);
            hashTable.Add("L", 50);
            hashTable.Add("C", 100);
            hashTable.Add("D", 500);
            hashTable.Add("M", 1000);

            int intNumber = 0;
            int tempNumber = 0;

            s = s.ToUpper();
            while(s.Length > 0)
            {
                tempNumber = 0;

                //If string length is more than one
                //If current character value is greater then immediate previous value, deduct n-1 th value from n value
                if(s.Length > 1 && ((int)hashTable[s.Substring(s.Length-1, 1)] > (int)hashTable[s.Substring(s.Length - 2, 1)]))
                {
                    tempNumber = (int)hashTable[s.Substring(s.Length - 1, 1)] - (int)hashTable[s.Substring(s.Length - 2, 1)];
                    intNumber += tempNumber;
                    s = s.Substring(0, s.Length - 2);
                }
                else
                {
                    intNumber += (int)hashTable[s.Substring(s.Length-1, 1)];
                    s = s.Substring(0, s.Length - 1);
                }
            }
            return intNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("v"));
            Console.ReadKey();
        }
    }
}
