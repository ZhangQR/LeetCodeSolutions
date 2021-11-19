using System;
using static LeetCodeSolutions.Tools;

namespace LeetCodeSolutions
{
    public class M397IntegerReplacement
    {
        
        public int IntegerReplacement(int n)
        {
            // 因为最大值会是 2^31 - 1 ，所以要改用 long
            return GetMinStep((long)n);
        }

        /// <summary>
        /// 获得减到 1 的最少步数
        /// </summary>
        /// <param name="num">当前值</param>
        /// <returns>最小步数</returns>
        public int GetMinStep(long num)
        {
            if (num == 1)
            {
                return 0;
            }
            
            // 是偶数
            if ((num & 1) == 0)
            {
                return 1 + GetMinStep(num >> 1);
            }
            return Math.Min(GetMinStep(num + 1), GetMinStep(num - 1)) + 1;
        }
    }
}