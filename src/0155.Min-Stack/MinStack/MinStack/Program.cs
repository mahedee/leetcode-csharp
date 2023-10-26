using System;
using System.Collections.Generic;

namespace MinStack
{
    public class MinStack
    {
        int min = Int32.MaxValue;
        Stack<int> stack = new Stack<int>();

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            // only push the old minimum value when the current 
            // minimum value changes after pushing the new value x
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            // if pop operation could result in the changing of the current minimum value, 
            // pop twice and change the current minimum value to the last minimum value.
            if (stack.Pop() == min) min = stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin()); //--> Returns - 3.
            minStack.Pop();
            Console.WriteLine(minStack.Top()); //--> Returns 0.
            Console.WriteLine(minStack.GetMin()); //--> Returns - 2.
            Console.ReadKey();
                
        }
    }
}
