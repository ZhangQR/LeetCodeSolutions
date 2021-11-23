using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata;

namespace LeetCodeSolutions
{
    /// <summary>
    /// 交换两个字母，判断是否一致
    /// https://leetcode-cn.com/problems/buddy-strings/
    /// </summary>
    public class S859BuddyStrings
    {
        public static bool BuddyStrings(string s, string goal)
        {
            int length = s.Length;
            if (length!=goal.Length || length == 1)
            {
                return false;
            }

            int diffNumber = 0, firstIndex = 0, secondIndex = 0;
            for (int i = 0; i < length; i++)
            {
                if (s[i]!=goal[i])
                {
                    diffNumber++;
                    if (diffNumber == 1)
                    {
                        firstIndex = i;
                    }else if (diffNumber == 2)
                    {
                        secondIndex = i;
                    }
                    else if(diffNumber > 2)
                    {
                        return false;
                    }
                }
            }

            if (diffNumber == 0)
            {
                // List<char> charList = new List<char>(s);
                // charList.Sort();
                // for (int i = 0; i < length-1; i++)
                // {
                //     if (charList[i] == charList[i + 1])
                //         return true;
                // }

                bool[] repeatRecord = new bool[26];
                for (int i = 0; i < length; i++)
                {
                    if (repeatRecord[s[i] - 'a'])
                    {
                        return true;
                    }
                    repeatRecord[s[i] - 'a'] = true;
                }
            }
            else if(diffNumber == 2)
            {
                return s[firstIndex] == goal[secondIndex] &&
                    s[secondIndex] == goal[firstIndex];
            }
            return false;
        }
    }
}