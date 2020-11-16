using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class ValidParantheses
    {
        public static bool isValid(string s)
        {
            if(s.Length == 1 && s.Length%2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                } else if(stack.Count != 0 && c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (stack.Count != 0 && c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (stack.Count != 0 && c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                } else
                {
                    return false;
                }
            }

            return stack.Count == 0;


        }



    }
}
