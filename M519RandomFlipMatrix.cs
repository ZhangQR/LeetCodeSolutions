using System;
using System.Collections.Concurrent;

namespace LeetCodeSolutions
{
    public class M519RandomFlipMatrix
    {
        public class Solution
        {
            private int[] indexRecord;
            private int currentIndex;
            private Random random;
            private int M, N;
            public Solution(int m, int n)
            {
                random = new Random(1);
                M = m;
                N = n;
                indexRecord = new int[M * N];
                for (int i = 0,k = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++,k++)
                    {
                        indexRecord[k] = k;
                    }
                }
                Reset();
            }
    
            public int[] Flip()
            {
                var index = random.Next(0, currentIndex);
                int m = indexRecord[index] / N;
                int n = indexRecord[index] % N;
                // OneDimensional2Two(indexRecord[index],N,out var m,out var n);
                (indexRecord[index], indexRecord[currentIndex - 1]) = 
                    (indexRecord[currentIndex - 1], indexRecord[index]);
                currentIndex--;
                return new[] {m, n};
            }
    
            public void Reset()
            {
                currentIndex = M * N;
                // for (int i = 0,k = 0; i < M; i++)
                // {
                //     for (int j = 0; j < N; j++,k++)
                //     {
                //         indexRecord[k] = k;
                //     }
                // }
                // int count = indexRecord.Length;
                // for (int i = 0; i < count; i++)
                // {
                //     indexRecord[i] = i;
                //     OneDimensional2Two(i,totalN,out int m,out int n);
                //     matrix[m, n] = 0;
                // }
            }

            private int TwoDimensional2One(int currentM, int currentN,int totalN)
            {
                return totalN * currentM + currentN;
            }

            private void OneDimensional2Two(int currentIndex,int totalN,out int m,out int n)
            {
                m = currentIndex / totalN;
                n = currentIndex % totalN;
            }
        }
    }
}