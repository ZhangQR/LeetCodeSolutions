using System;
using System.ComponentModel;

namespace LeetCodeSolutions
{
    public class M400NthDigit
    {
        // n 的范围是 int 的最大值
        public int FindNthDigit(int n)
        {
            // int i = 1;
            Int64 i=1,pow;
            while (true)
            {
                pow = (Int64) Math.Pow(10, i - 1);
                // 所以这里用 int 有可能会爆
                Int64 baseNumber = i * 9 * pow;
                if (n - baseNumber <= 0)
                {
                    break;
                }
                n -= (int)baseNumber;
                i++;
            }
            Int64 number = --n / i + pow;
            Int64 mod = n % i;
            return int.Parse(number.ToString().Substring((int)mod,1));
        }
    }
}