using System.Diagnostics;
using static LeetCodeSolutions.Tools;

namespace LeetCodeSolutions
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-product-of-word-lengths/
    /// 一个 int 32 bit，每个字符串最多出现 26 bit，记录完成后按位与
    /// </summary>
    public class M318MaximumProductofWordLengths 
    {
        public int MaxProduct(string[] words)
        {
            int length = words.Length;
            int[] record = new int[length];
            int maxProduct = 0;
            for (int i = 0; i < length; i++)
            {
                record[i] = RecordInInt(words[i]);
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if ((record[i] & record[j]) == 0)
                    {
                        int product = words[i].Length * words[j].Length;
                        maxProduct = maxProduct < product ? product : maxProduct;
                    }
                }
            }
            return maxProduct;
        }

        public int RecordInInt(string s)
        {
            int record = 0;
            foreach (var c in s)
            {
                int charIndex = c - 'a';
                record = record | 1 << charIndex;
            }
            return record;
        }
    }
}