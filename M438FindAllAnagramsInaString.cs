using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class M438FindAllAnagramsInaString
    {
        // 排序会超时
        // public IList<int> FindAnagrams(string s, string p)
        // {
        //     List<int> ret = new List<int>();
        //     int length = s.Length - p.Length + 1, pLength = p.Length;
        //     var pArray  = p.ToArray();
        //     Array.Sort(pArray);
        //     for (int i = 0; i < length; i++)
        //     {
        //         string sPart = s.Substring(i, pLength);
        //         var sPartArray = sPart.ToArray();
        //         Array.Sort(sPartArray);
        //         for (int j = 0; j < pLength; j++)
        //         {
        //             if (pArray[j] != sPartArray[j])
        //             {
        //                 break;
        //             }
        //
        //             if (j == pLength-1)
        //             {
        //                 ret.Add(i);    
        //             }
        //         }
        //     }
        //     return ret;
        // }

        // 使用滑动窗口来做很快
        public IList<int> FindAnagrams(string s, string p)
        {
            int sLength = s.Length, pLength = p.Length, length = sLength - pLength + 1;
            List<int> ret = new List<int>();
            if (length < 1)
            {
                return ret;
            }
            int[] numberRecord = new int[26];
            int[] pNumberRecord = new int[26];
            for (int i = 0; i < pLength; i++)
            {
                numberRecord[s[i] - 'a']++;
                pNumberRecord[p[i] - 'a']++;
            }

            for (int i = 0; i < length; i++)
            {
                // if (numberRecord.Equals(pNumberRecord))
                if(ArrayEquals(numberRecord,pNumberRecord))
                {
                    ret.Add(i);
                }
                numberRecord[s[i] - 'a']--;
                if (i != length-1)
                {
                    numberRecord[s[i + pLength] - 'a']++;    
                }
            }
            return ret;
        }

        private bool ArrayEquals(in int[] array1, in int[] array2)
        {
            int length = array1.Length;
            for (int i = 0; i < length; i++)
            {
                if (array1[i]!=array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}