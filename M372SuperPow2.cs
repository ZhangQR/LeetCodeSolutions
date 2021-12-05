using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class M372SuperPow2
    {
        private const int Mod = 1337;
        public int SuperPow(int a, int[] b)
        {
            a %= Mod;
            int length = b.Length;
            if (b.Length == 1)
            {
                return MyPow(a, b[0]) % Mod;
            }
            List<int> nextB = new List<int>(b);
            nextB.RemoveAt(length-1);
            return MyPow(a, b[length-1]) * MyPow(SuperPow(a, nextB.ToArray()), 10) % Mod;
        }

        private int MyPow(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            return x * MyPow(x, --y) % Mod;
        }
    }
}