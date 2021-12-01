using System;

namespace LeetCodeSolutions
{
    public class S1446ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            int length = s.Length;
            if (length == 1)
            {
                return 1;
            }
            int currentCount = 1, maxCount = 0;
            for (int i = 1; i < length; i++)
            {
                if (s[i] == s[i-1])
                {
                    currentCount++;
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }
            return Math.Max(currentCount,maxCount);
        }
    }
}