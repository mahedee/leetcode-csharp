using System;
using System.Collections.Generic;
using System.Text;

namespace LongestCommonPrefix
{
    public class DivideConquer
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0 || strs == null)
            {
                return "";
            }
            else
            {
                return LongestCommonPrefix(strs, 0, strs.Length - 1);
            }
        }

        private static string LongestCommonPrefix(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            else
            {
                int mid = (l + r) / 2;

                string lcpLeft = LongestCommonPrefix(strs, l, mid);
                string lcpRight = LongestCommonPrefix(strs, mid + 1, r);
                return CommonPrefix(lcpLeft, lcpRight);
            }
        }
        private static string CommonPrefix(string left, string right)
        {
            int minLen = Math.Min(left.Length, right.Length);

            for(int i = 0; i < minLen; i++)
            {
                if(left[i] != right[i])
                {
                    return left.Substring(0, i);
                }
            }
            return left.Substring(0, minLen);
        }
    }
}
