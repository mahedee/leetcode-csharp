using System;
using System.Text;

namespace LongestCommonPrefix
{
    public class Program
    {

        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder outputString = new StringBuilder();
            outputString.Append("");
            //Base condition
            if (strs.Length < 1)
                return outputString.ToString();

            int noOfInput = strs.Length;

            int minStrLength = strs[0].Length;
            for(int i = 1; i < strs.Length; i++)
            {
                if(minStrLength > strs[i].Length)
                {
                    minStrLength = strs[i].Length;
                }
            }

            if (minStrLength < 1)
                return outputString.ToString();

            for(int i = 0; i < minStrLength; i++)
            {
                //Check each string array
                for(int j = 0; j < strs.Length-1; j++)
                {
                    //Check current string array and next string array
                    if(strs[j].Substring(i, 1) != strs[j+1].Substring(i, 1))
                    {
                        return outputString.ToString();
                    }
                }

                outputString.Append(strs[0].Substring(i, 1));
            }


            return outputString.ToString();
        }

        static void Main(string[] args)
        {
            //string[] strArray = { "flower", "flow", "faight" };
            //Console.WriteLine(VerticalScanning.LongestCommonPrefix(strArray));
            //Console.WriteLine(LongestCommonPrefix(strArray));

            string[] strArray = { "flower", "flow", "flight" };
            Console.WriteLine(DivideConquer.LongestCommonPrefix(strArray));

            Console.ReadKey();
        }
    }
}
