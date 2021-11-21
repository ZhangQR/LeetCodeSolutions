using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace LeetCodeSolutions
{
    public class S594LongestHarmoniousSubsequence
    {
        public int FindLHS(int[] nums)
        {
            List<int> numList = new List<int>(nums);
            numList.Sort();
            int length = numList.Count;
            int maxCount = 0, nowTotalCount = 1, nowCount = 1;
            bool isZero = true;
            bool hasFirst = true, hasSecond = false;
            for (int i = 0; i < length-1; i++)
            {
                int nextNum = numList[i + 1],
                    nowNum = numList[i];
                if (nextNum == nowNum)
                {
                    nowCount++;
                    if (hasFirst && hasSecond)
                    {
                        nowTotalCount++;
                    }
                }else if (nextNum - nowNum == 1)
                {
                    isZero = false;
                    if (!hasSecond)
                    {
                        hasSecond = true;
                        nowTotalCount = nowCount + 1;
                        nowCount = 1;
                    }else
                    {
                        nowTotalCount = nowCount + 1;
                        nowCount = 1;
                    }
                }else
                {
                    hasSecond = false;
                    nowCount = 1;
                    nowTotalCount = 1;
                }
                if (maxCount < nowTotalCount)
                {
                    maxCount = nowTotalCount;
                }
            }

            if (isZero) return 0;
            return maxCount;
        }
    }
}