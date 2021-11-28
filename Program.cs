﻿using System;
using System.Text;
using System.Threading;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetMaximumGold();
            // IsSumEquals();
            // MaximumProductOfWordLengths();
            // BinaryTreeTilt();
            // IntegerReplacement();
            // O1();
            //O2Solution.answer(1241);
            // O3();
            // O4();
            // LongestHarmoniousSubsequence();
            // BuddyString();
            // ReconstructOriginalDigitsfromEnglish();
            // PoorPigs();
            // RandomFlipMatrix();
            // LeetCodeSolutions.O4.ListTest();
            FindAllAnagramsInaString();
        }

        /// <summary>
        /// M 乱序一个要想到排序，一个就是只记录数量，这里排序会超时（JAVA 同样的写法竟然不会），所以使用第二种滑动窗口来做
        /// https://leetcode-cn.com/problems/find-all-anagrams-in-a-string/
        /// </summary>
        public static void FindAllAnagramsInaString()
        {
            string s = "cbaebabacd";
            string p = "abc";
            // string s = "abab", p = "ab";
            M438FindAllAnagramsInaString m438FindAllAnagramsInaString = new M438FindAllAnagramsInaString();
            m438FindAllAnagramsInaString.FindAnagrams(s, p);
        }

        /// <summary>
        /// M 随机翻牌二维数组
        /// 时间和内存都有卡点，不需要 matrix[m,n],reset 的时候也不需要重置 record 数组
        /// https://leetcode-cn.com/problems/random-flip-matrix/
        /// </summary>
        public static void RandomFlipMatrix()
        {
            int m = 3, n = 1;
            M519RandomFlipMatrix.Solution m519RandomFlipMatrix = new M519RandomFlipMatrix.Solution(m,n);
            Console.Write(m519RandomFlipMatrix.Flip());
            Console.Write(m519RandomFlipMatrix.Flip());
            Console.Write(m519RandomFlipMatrix.Flip());
            m519RandomFlipMatrix.Reset();
            Console.Write(m519RandomFlipMatrix.Flip());
        }

        /// <summary>
        /// H 毒药喂猪
        /// https://leetcode-cn.com/problems/poor-pigs/
        /// </summary>
        public static void PoorPigs()
        {
            H458PoorPigs h458PoorPigs = new H458PoorPigs();
            Console.Write(h458PoorPigs.PoorPigs(1000, 15, 60));
        }

        /// <summary>
        /// M 将打乱的英文数字还原
        /// https://leetcode-cn.com/problems/reconstruct-original-digits-from-english/
        /// </summary>
        public static void ReconstructOriginalDigitsfromEnglish()
        {
            // string input = "owoztneoer";
            string input = "fviefuro";
            M423ReconstructOriginalDigitsFromEnglish m423ReconstructOriginalDigitsFromEnglish =
                new M423ReconstructOriginalDigitsFromEnglish();
            Console.Write(m423ReconstructOriginalDigitsFromEnglish.OriginalDigits(input));
        }

        /// <summary>
        /// S 交换两个字母判断是否相等
        /// </summary>
        public static void BuddyString()
        {
            string s1 = "abab";
            string s2 = "abab";
            Console.Write(S859BuddyStrings.BuddyStrings(s1, s2));
        }

        public static void LongestHarmoniousSubsequence()
        {
            // int[] input = {1, 3, 2, 2, 5, 2, 3, 7};
            int[] input = {1, 2, 3, 4};
            //int[] input = {1, 1, 1, 1};
            //int[] input = {1, 2, 2, 1};
            Console.Write(new S594LongestHarmoniousSubsequence().FindLHS(input));
        }
        
        public static void O1()
        {
            int[] x = new int[10];
            for (int i = 1; i <= x.Length; i++)
            {
                x[i - 1] = i;
            }

            x = new[] {85, 398, 421, 189, 30,87};

            var answer = LeetCodeSolutions.O1.answer(x);
            Console.Write(answer[0]);
            
            // part2
            // int[] input = new[] {1, 2, 3, 4};
            // int answer = LeetCodeSolutions.O1.part2(input);
            // Console.Write(answer);
            
            // part3
            // int input = 72;
            // LeetCodeSolutions.O1.part3(input);
        }
        
        static void O3()
        {
            LeetCodeSolutions.O3 o1 = new O3();
        }
        static void O4()
        {
            LeetCodeSolutions.O4 o1 = new O4();
        }

        /// <summary>
        /// 中等：dfs+回溯 获得最大值
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
        
        /// <summary>
        /// 简单：https://leetcode-cn.com/problems/check-if-word-equals-summation-of-two-words/
        /// </summary>
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

        /// <summary>
        /// 中等：按位与操作
        /// https://leetcode-cn.com/problems/maximum-product-of-word-lengths/
        /// </summary>
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

        /// <summary>
        /// 简单：二叉树输出
        /// https://leetcode-cn.com/problems/binary-tree-tilt/submissions/
        /// </summary>
        static void BinaryTreeTilt()
        {
            // int[] input = {4, 2, 9, 3, 5, 10, 7};
            // int[] input = {1,2};
            // int[] input = {1,2,3,4,5};
            int[] input = {-8,-6,7,6,0,0,0,0,5};
            
            S563BinaryTreeTilt.TreeNode tree = new S563BinaryTreeTilt.TreeNode(input);
            tree.left.left.left = null;
            tree.left.right = null;
            tree.right.left = null;
            tree.right.right = null;
            S563BinaryTreeTilt s563BinaryTreeTilt = new S563BinaryTreeTilt();
            // S563BinaryTreeTilt.PrintBinaryTree(tree);
            Console.Write(s563BinaryTreeTilt.FindTilt(tree));
        }

        /// <summary>
        /// 中等：整数替换
        /// https://leetcode-cn.com/problems/integer-replacement/
        /// </summary>
        static void IntegerReplacement()
        {
            M397IntegerReplacement m397IntegerReplacement = new M397IntegerReplacement();
            int result = m397IntegerReplacement.IntegerReplacement(2147483647);
            Console.Write(result);
        }


    }
}