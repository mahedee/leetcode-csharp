using System;
using System.Collections.Generic;
using System.Text;

namespace LongestCommonPrefix
{
    public class HorizontalScanning
    {

        //Time complexity : O(S)O(S) , where S is the sum of all characters in all strings.
        //Space complexity : O(1)O(1). We only used constant extra space. 
        public static string LongestCommonPrefix(string[] strs)
        {
            //if no string array as input
            //base criteria
            if (strs.Length == 0)
                return "";

            //Take the first string as prefix
            //Initially take full string as prefix
            string prefix = strs[0];

            //Scanning all string, 1 to n-1 . Since strs[0] is in prefix, so we chake first string with second string and find out matching prefix
            for(int i = 1; i < strs.Length; i++)
            {
                //if two string are same then it str.IndexOf("str") = 0
                //If it is not matched it will return - 1
                //Otherwise it will send maching index. For example 2, if it is matched from index 2
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if(prefix == "")
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
    }
}
