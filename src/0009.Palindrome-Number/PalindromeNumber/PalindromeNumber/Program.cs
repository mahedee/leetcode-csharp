using System;

namespace PalindromeNumber
{
    public class Program
    {

        /// <summary>
        /// Optimized solution
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {

            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            int res = 0;
            while (x > revertedNumber)
            {
                res = x % 10;
                revertedNumber = revertedNumber * 10 + res;
                x = x / 10;
            }


            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }


        public static bool IsPalindromeSolution1(int x)
        {

            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int firstDigit = 0;
            int lastDigit = 0;

            int reverseX = x;
            int noOfDigit = (int)(Math.Log10(x) + 1);
            int reverseDigit = noOfDigit;

            for (int i = 1; i <= noOfDigit / 2; i++)
            {
                lastDigit = x % 10;
                x = x / 10;

                firstDigit = (int)(reverseX / Math.Pow(10, reverseDigit - i));

                reverseX = reverseX - (int)(Math.Pow(10, reverseDigit - i) * firstDigit);
                if (firstDigit != lastDigit)
                {
                    return false;
                }
            }

            return true;
        }


        //Main method is for testing
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindromeSolution1(123321));
            Console.WriteLine(IsPalindrome(121));
            Console.ReadKey();
        }
    }
}
