using System;
using System.Collections.Generic;
using System.Globalization;

namespace LeetCodeSolutions
{
    /// <summary>
    /// 随机打乱数组，自己写的话可以从后往前遍历进行交换
    /// https://leetcode-cn.com/problems/shuffle-an-array/
    /// </summary>
    public class M384ShuffleAnArray
    {
        private int[] nums;
        public M384ShuffleAnArray(int[] nums)
        {
            this.nums = nums;
        }
        
        public int[] Reset()
        {
            return nums;
        }
        
        public int[] Shuffle()
        {
            List<int> remainingNumber = new List<int>(nums);
            int length = remainingNumber.Count;
            List<int> ret = new List<int>(length);
            Random random = new Random();
            while (length>0)
            {
                int crtItemIndex = random.Next(0, length); 
                ret.Add(remainingNumber[crtItemIndex]);
                remainingNumber.RemoveAt(crtItemIndex);
                length = remainingNumber.Count;
            }

            return ret.ToArray();
        }
    }
}