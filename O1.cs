using System;
using System.Collections.Generic;
using static LeetCodeSolutions.Tools;
namespace LeetCodeSolutions
{
    /// <summary>
    /// 某公司 A 笔试题第一道
    /// </summary>
    public class O1
    {
        public static int[] answer(int[] x)
        {
            int[] part1Answer = part1(x);
            int part2Answer = part2(part1Answer);
            return part3(part2Answer);
        }

        public static int[] part1(int[] x)
        {
            int length = x.Length;
            if (length <= 2)
            {
                return x;
            }

            int[] ret = new int[2]; 
            for (int i = 0; i < length-1; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if (x[i] + x[j] == 46)
                    {
                        ret[0] = i;
                        ret[1] = j;
                        return ret;
                    }
                }
            }

            ret[0] = x[0];
            ret[1] = x[1];
            return ret;
        }

        public static int part2(int[] x)
        {
            int ret = 0,length = x.Length;
            if (length == 0)
            {
                return 4;
            }

            int loopTimes = 0;
            if ((length & 1) == 0)
            {
                loopTimes = 4;
            }
            else
            {
                loopTimes = 5;
            }
            int startIndex = (length >> 1) - 2;
            for (int i = startIndex; i < loopTimes; i++)
            {
                if (0<=i && i<length)
                {
                    ret += x[i];   
                }
            }

            return ret;
        }

        public static int[] part3(int input)
        {
            const int retCount = 6;
            int[] ret = new int[retCount];
            input = Math.Abs(input);
            int[] approNumber = GetApproximateNumber(input);
            int appLength = approNumber.Length;
            if (appLength>retCount)
            {
                for (int i = retCount-1; i >=0; i--)
                {   
                    int appIndex = appLength - i - 1;
                    if (appIndex < appLength)
                    {
                        ret[i] = approNumber[appIndex];
                    }
                }
            }
            else
            {
                ret = new int[appLength];
                for (int i = 0; i < appLength; i++)
                {
                    ret[i] = approNumber[i];
                }
            }
            return ret;
        }

        public static int[] GetApproximateNumber(int number)
        {
            int length = (int)Math.Sqrt(number);
            List<int> firstPart = new List<int>();
            Stack<int> secondPart = new Stack<int>();
            for (int i = 1; i <= length; i++)
            {
                if (number % i == 0)
                {
                    firstPart.Add(i);
                    secondPart.Push(number/i);
                }
            }

            int secondLength = secondPart.Count;
            for (int i = 0; i < secondLength; i++)
            {
                int num = secondPart.Pop();
                if (!firstPart.Contains(num))
                {
                    firstPart.Add(num);
                }
            }

            return firstPart.ToArray();
        }
    }
}