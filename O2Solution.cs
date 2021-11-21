using System.Collections.Generic;
using System.Threading;

namespace LeetCodeSolutions
{
    /// <summary>
    /// 某公司 A 笔试题第二道
    /// </summary>
    public class O2Solution
    {
        public static int[] answer(int x)
        {
            // part1
            List<int> part1Answer = new List<int>();
            int mod = 10, div = 1;
            while (true)
            {
                int num = x % mod / div;
                if (num!=0)
                {
                    part1Answer.Add(num);
                    mod *= 10;
                    div *= 10;
                }
                else
                {
                    break;
                }
            }
            part1Answer.Reverse();
            int[] temp = part1Answer.ToArray();
            for (int i = 0; i < 10; i++)
            {
                part1Answer.AddRange(temp);
            }
            
            // part2
            // part1Answer = new List<int>() {1, 2, 3, 4};
            int part2Answer = 0;
            int loopTimes = 0;
            int length = part1Answer.Count;
            if (length == 0)
            {
                part2Answer = 6;
            }else if ((length & 1) == 1)
            {
                loopTimes = 7;
            }
            else
            {
                loopTimes = 6;
            }
            int startIndex = (length >> 1) - 3;
            for (int i = startIndex,j = 0; j < loopTimes; i++,j++)
            {
                if (0<=i && i<length)
                {
                    part2Answer += part1Answer[i];   
                }
            }
            
            // part3
            int[] part3Answer = new int[4];
            if (part2Answer < 4)
            {
                loopTimes = part2Answer;
            }
            else
            {
                loopTimes = 4;
            }
            
            for (int i = 1; i <= loopTimes; i++)
            {
                part3Answer[i-1] = i;
            }

            return part3Answer;
        }
        
    }
}