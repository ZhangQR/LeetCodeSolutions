using System;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetMaximumGold();
            // IsSumEquals();
            MaximumProductOfWordLengths();
        }

        /// <summary>
        /// dfs+回溯 获得最大值
        /// https://leetcode-cn.com/problems/path-with-maximum-gold/
        /// </summary>
        static void GetMaximumGold()
        {
                       // int[,] grid = new int[3,3]
            // {
            //     {0,6,0},
            //     {5,8,7},
            //     {0,9,0}
            // };
            // int[,] grid = new int[5,3]
            // {
            //     {1,0,7},
            //     {2,0,6},
            //     {3,4,5},
            //     {0,3,0},
            //     {9,0,20}
            // };
            //
            // int[][] grid = 
            // {
            //     new []{1, 0, 7},
            //     new []{2,0,6},
            //     new []{3,4,5},
            //     new []{0,3,0},
            //     new []{9,0,20}
            // };
            // int[,] grid = new int[,]
            // {
            //     {1, 0, 7, 0, 0, 0},
            //     {2, 0, 6, 0, 1, 0},
            //     {3, 5, 6, 7, 4, 2},
            //     {4, 3, 1, 0, 2, 0},
            //     {3, 0, 5, 0, 20, 0}
            // };

            // int[,] grid = new int[6, 5];
            // for (int i = 0,nn = 1; i < grid.GetLength(0); i++)
            // {
            //     for (int j = 0; j < grid.GetLength(1); j++,nn++)
            //     {
            //         grid[i, j] = nn;
            //     }
            // }

            int[][] grid =
            {
                new []{0,  0,  0,  0,  0,  0,  32, 0,  0,  20},
                new []{0,  0,  2,  0,  0,  0,  0,  40, 0,  32},
                new []{13, 20, 36, 0,  0,  0,  20, 0,  0,  0},
                new []{0,  31, 27, 0,  19, 0,  0,  25, 18, 0},
                new []{0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                new []{0,  0,  0,  0,  0,  0,  0,  18, 0,  6},
                new []{0,  0,  0,  25, 0,  0,  0,  0,  0,  0},
                new []{0,  0,  0,  21, 0,  30, 0,  0,  0,  0},
                new []{19, 10, 0,  0,  34, 0,  2,  0,  0,  27},
                new []{0,  0,  0,  0,  0,  34, 0,  0,  0,  0}
            };
            M1219PathWithMaximumGold m1219PathWithMaximumGold = new M1219PathWithMaximumGold();
            Console.WriteLine(m1219PathWithMaximumGold.GetMaximumGold(grid));
        }
        static void IsSumEquals()
        {
            S1880CheckIfWordEqualsSummationOfTwoWords s1880CheckIfWordEqualsSummationOfTwoWords = new S1880CheckIfWordEqualsSummationOfTwoWords();
            string firstWord, secondWord, targetWord;
            // firstWord = "acb";
            // secondWord = "cba";
            // targetWord = "cdb";
            
            // firstWord = "aaa";
            // secondWord = "a";
            // targetWord = "aab";

            firstWord = "aaa";
            secondWord = "a";
            targetWord = "aaaa";
            Console.Write(s1880CheckIfWordEqualsSummationOfTwoWords.IsSumEqual(firstWord,secondWord,targetWord));
        }

        static void MaximumProductOfWordLengths()
        {
            // string[] words =
            // {
            //     "abcw", "baz", "foo", "bar", "xtfn", "abcdef"
            // };

            // string[] words =
            // {
            //     "a", "ab", "abc", "d", "cd", "bcd", "abcd"
            // };

            string[] words =
            {
                "a", "aa", "aaa", "aaaa"
            };
            
            M318MaximumProductofWordLengths maximumProductofWordLengths = new M318MaximumProductofWordLengths();
            Console.Write(maximumProductofWordLengths.MaxProduct(words));
        }
    }
}