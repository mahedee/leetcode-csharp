using System;
using System.Collections.Generic;
using System.Text;

namespace LongestCommonPrefix
{
    public class VerticalScanning
    {

        //Time complexity : O(S)O(S) , where S is the sum of all characters in all strings.
        //Space complexity : O(1)O(1). We only used constant extra space. 
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            //Scanning each elements of first string with other string
            for (int i = 0; i < strs[0].Length; i++)
            {
                //character at index i
                //each character of first string
                char c = strs[0][i];

                //Scanning each string with first string. 2nd string and others.
                for (int j = 1; j < strs.Length; j++)
                {
                    //if str[j] length is equal to scanning character, then stop, scanning
                    //if ith character of j is not match just return substring
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                }
            }
            return strs[0];
        }
    }
}
