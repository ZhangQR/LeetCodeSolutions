using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class S506RelativeRanks
    {
        private static readonly string[] medals =
        {
            "Gold Medal", "Silver Medal", "Bronze Medal"
        };
        private SortedDictionary<int, int> scoreIndexPair;
        public string[] FindRelativeRanks(int[] score)
        {
            int length = score.Length;
            string[] ret = new string[length];
            scoreIndexPair = new SortedDictionary<int, int>(new IntComparer());
            for (int i = 0; i < length; i++)
            {
                scoreIndexPair.Add(score[i],i);
            }
            for (int i = 0; i < length; i++)
            {
                (int key, int value) = scoreIndexPair.ElementAt(i);
                if (i < 3)
                {
                    ret[value] = medals[i];
                }
                else
                {
                    ret[value] = (i+1).ToString();
                }
            }
            return ret;
        }
    }

    public class IntComparer : IComparer<int>
    {
        public  int Compare(int a, int b)
        {
            return a == b ? 0 : a > b ? -1 : 1;
        }
    }
}