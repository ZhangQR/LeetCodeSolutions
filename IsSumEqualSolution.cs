using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class IsSumEqualSolution
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord) 
        {
            // Console.Write(GetLetterValue('j'));
            // Console.Write(GetNumericalValue("abcd"));
            return GetNumericalValue(firstWord)+GetNumericalValue(secondWord) == GetNumericalValue(targetWord);
        }

        public int GetNumericalValue(string s)
        {
            char[] ss = s.ToCharArray();
            int ret = 0;
            foreach (char c in ss)
            {
                ret = ret * 10 + GetLetterValue(c);
            }

            return ret;
        }

        public int GetLetterValue(char c)
        {
            return (int)c - 97;
        }
    }
}