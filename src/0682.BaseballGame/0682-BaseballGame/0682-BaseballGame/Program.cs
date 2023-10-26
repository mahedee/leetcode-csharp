
using System;
public class Program
{ 
    //Main method is for testing
    static void Main(string[] args)
    {
        //Console.WriteLine(IsPalindromeSolution1(123321));
        //string[] input = new string[] { "5", "2", "C", "D", "+" };
        //string[] input = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };

        string[] input = new string[] { "1", "C" };

        Console.WriteLine(new Solution().CalPoints(input));
        Console.ReadKey();
    }
}

