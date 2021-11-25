using System;

namespace LeetCodeSolutions
{
    public class H458PoorPigs
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            int times = minutesToTest / minutesToDie + 1;
            // Console.Write(Math.Pow(buckets,(float)1/times));
            return (int)Math.Ceiling(Math.Log(buckets,times));
        }
    }
}