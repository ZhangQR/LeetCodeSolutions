using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    /// <summary>
    /// 稍微比第一种方法快一点，没有 GetValueIndex 方法就更好了
    /// </summary>
    public class S506RelativeRanks2
    {
        private static readonly string[] medals =
        {
            "Gold Medal", "Silver Medal", "Bronze Medal"
        };
        private int[] scoreCopy;
        public string[] FindRelativeRanks(int[] score)
        {
            int length = score.Length;
            scoreCopy = new int[length];
            string[] ret = new string[length];
            score.CopyTo(scoreCopy,0);
            // Array.Sort(scoreCopy,new IntComparer());
            // 默认是升序排列
            Array.Sort(scoreCopy);
            for (int i = length - 1; i >= 0; i--)
            {
                string s = i > length - 4
                    ? medals[length - 1 - i] :
                        (length - i).ToString();
                ret[GetValueIndex(in score, scoreCopy[i])] = s;
            }
            return ret;
        }

        private int GetValueIndex(in int[] list,int value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}