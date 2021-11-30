using System;
using System.Collections;
using System.Collections.Generic;
namespace LeetCodeSolutions
{
    public class H786KthSmallestPrimeFraction
    {
        public class Fractional : IComparable
        {
            public int Denominator; // 分母
            public int Numerator;   // 分子

            public Fractional(int numerator, int denominator)
            {
                this.Denominator = denominator;
                this.Numerator = numerator;
            }

            public int[] TranslateToIntArray()
            {
                return new[] {Numerator, Denominator};
            }
            
            public int CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 1;
                }
                Fractional other = obj as Fractional;
                if (other != null)
                {
                    if (Denominator == other.Denominator && Numerator == other.Numerator)
                    {
                        return 0;
                    }
                    // 坑点一：返回值是 int 不能直接用减法，不然 0.11-0.1 结果是 0
                    // 坑点二：注意数据精度，精度太高用 float 的话，也有可能返回 0
                    return Numerator / (double)Denominator - other.Numerator / (double)other.Denominator > 0 ? 1 : -1;
                }
                throw new ArgumentException("Object is not a Fractional");
            }
        }
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            SortedSet<Fractional> fractionalSet = new SortedSet<Fractional>();
            int length = arr.Length;
            for (int i = 0; i < length -1 ; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    Fractional fractional = new Fractional(arr[i], arr[j]);
                    if (fractionalSet.Count < k || fractional.CompareTo(fractionalSet.Max) < 0)
                    {
                        if (fractionalSet.Count == k)
                        {
                            fractionalSet.Remove(fractionalSet.Max);
                        }
                        fractionalSet.Add(fractional);
                    }
                }
            }
            return fractionalSet.Max.TranslateToIntArray();
        }
    }
}