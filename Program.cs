using System;
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
            // FindAllAnagramsInaString();
            // KthSmallestPrimeFraction();
            // NthDigit();
            // MaxPower();
            // FindRelativeRanks();
            // MaximizeSumOfArrayAfterKNegations();
            // SuperPow();
            // TruncateSentence();
            ColoringABorder();
        }
        
        /// <summary>
        /// M BFS
        /// https://leetcode-cn.com/problems/coloring-a-border/
        /// </summary>
        public static void ColoringABorder()
        {
            // int[][] input = new[]
            // {
            //     new int[] {1, 1},
            //     new int[] {1, 2}
            // };
            // int row = 0, col = 0, color = 3;

            // int[][] input = new[]
            // {
            //     new int[] {1, 1, 1},
            //     new int[] {1, 1, 1},
            //     new int[] {1, 1, 1}
            // };
            // int row = 1, col = 1, color = 3;

            int[][] input = new[]
            {
                new int[] {1, 2, 1, 2, 1, 2},
                new int[] {2, 2, 2, 2, 1, 2},
                new int[] {1, 2, 2, 2, 1, 2}
            };
            int row = 1, col = 3, color = 1;
            M1034ColoringABorder m1034ColoringABorder = new M1034ColoringABorder();
            m1034ColoringABorder.ColorBorder(input,row,col,color);
        }
        
        /// <summary>
        /// S 简单
        /// https://leetcode-cn.com/problems/truncate-sentence/
        /// </summary>
        public static void TruncateSentence()
        {
            string input = "What is the solution to this problem";
            int k = 4;
            S1816TruncateSentence s1816TruncateSentence = new S1816TruncateSentence();
            Console.Write(s1816TruncateSentence.TruncateSentence(input,k));
        }
        

        /// <summary>
        /// M 快速幂
        /// https://leetcode-cn.com/problems/super-pow/
        /// </summary>
        public static void SuperPow()
        {
            // int a = 2;
            // int[] b = {1, 0};
            
            // int a = 2147483647;
            int a = 2147483647;
            int[] b = {2, 0, 0};

            // int a = 1;
            // int[] b = {4, 3, 3, 8, 5, 2};
            
            // int a = 2;
            // int[] b = {3};
            
            // int a = 78267;
            // int[] b =
            // {
            //     1,7,7,4,3,1,7,0,1,4,4,9,2,8,5,0,0,9,3,1,2,5,9,6,0,9,9,0,9,6,0,5,3,7,9,8,8,9,8,2,5,4,1,9,3,8,0,5,9,5,6,1,1,8,9,3,7,8,5,8,5,5,3,0,4,3,1,5,4,1,7,9,6,8,8,9,8,0,6,7,8,3,1,1,1,0,6,8,1,1,6,6,9,1,8,5,6,9,0,0,1,7,1,7,7,2,8,5,4,4,5,2,9,6,5,0,8,1,0,9,5,8,7,6,0,6,1,8,7,2,9,8,1,0,7,9,4,7,6,9,2,3,1,3,9,9,6,8,0,8,9,7,7,7,3,9,5,5,7,4,9,8,3,0,1,2,1,5,0,8,4,4,3,8,9,3,7,5,3,9,4,4,9,3,3,2,4,8,9,3,3,8,2,8,1,3,2,2,8,4,2,5,0,6,3,0,9,0,5,4,1,1,8,0,4,2,5,8,2,4,2,7,5,4,7,6,9,0,8,9,6,1,4,7,7,9,7,8,1,4,4,3,6,4,5,2,6,0,1,1,5,3,8,0,9,8,8,0,0,6,1,6,9,6,5,8,7,4,8,9,9,2,4,7,7,9,9,5,2,2,6,9,7,7,9,8,5,9,8,5,5,0,3,5,8,9,5,7,3,4,6,4,6,2,3,5,2,3,1,4,5,9,3,3,6,4,1,3,3,2,0,0,4,4,7,2,3,3,9,8,7,8,5,5,0,8,3,4,1,4,0,9,5,5,4,4,9,7,7,4,1,8,7,5,2,4,9,7,9,1,7,8,9,2,4,1,1,7,6,4,3,6,5,0,2,1,4,3,9,2,0,0,2,9,8,4,5,7,3,5,8,2,3,9,5,9,1,8,8,9,2,3,7,0,4,1,1,8,7,0,2,7,3,4,6,1,0,3,8,5,8,9,8,4,8,3,5,1,1,4,2,5,9,0,5,3,1,7,4,8,9,6,7,2,3,5,5,3,9,6,9,9,5,7,3,5,2,9,9,5,5,1,0,6,3,8,0,5,5,6,5,6,4,5,1,7,0,6,3,9,4,4,9,1,3,4,7,7,5,8,2,0,9,2,7,3,0,9,0,7,7,7,4,1,2,5,1,3,3,6,4,8,2,5,9,5,0,8,2,5,6,4,8,8,8,7,3,1,8,5,0,5,2,4,8,5,1,1,0,7,9,6,5,1,2,6,6,4,7,0,9,5,6,9,3,7,8,8,8,6,5,8,3,8,5,4,5,8,5,7,5,7,3,2,8,7,1,7,1,8,7,3,3,6,2,9,3,3,9,3,1,5,1,5,5,8,1,2,7,8,9,2,5,4,5,4,2,6,1,3,6,0,6,9,6,1,0,1,4,0,4,5,5,8,2,2,6,3,4,3,4,3,8,9,7,5,5,9,1,8,5,9,9,1,8,7,2,1,1,8,1,5,6,8,5,8,0,2,4,4,7,8,9,5,9,8,0,5,0,3,5,5,2,6,8,3,4,1,4,7,1,7,2,7,5,8,8,7,2,2,3,9,2,2,7,3,2,9,0,2,3,6,9,7,2,8,0,8,1,6,5,2,3,0,2,0,0,0,9,2,2,2,3,6,6,0,9,1,0,0,3,5,8,3,2,0,3,5,1,4,1,6,8,7,6,0,9,8,0,1,0,4,5,6,0,2,8,2,5,0,2,8,5,2,3,0,2,6,7,3,0,0,2,1,9,0,1,9,9,2,0,1,6,7,7,9,9,6,1,4,8,5,5,6,7,0,6,1,7,3,5,9,3,9,0,5,9,2,4,8,6,6,2,2,3,9,3,5,7,4,1,6,9,8,2,6,9,0,0,8,5,7,7,0,6,0,5,7,4,9,6,0,7,8,4,3,9,8,8,7,4,1,5,6,0,9,4,1,9,4,9,4,1,8,6,7,8,2,5,2,3,3,4,3,3,1,6,4,1,6,1,5,7,8,1,9,7,6,0,8,0,1,4,4,0,1,1,8,3,8,3,8,3,9,1,6,0,7,1,3,3,4,9,3,5,2,4,2,0,7,3,3,8,7,7,8,8,0,9,3,1,2,2,4,3,3,3,6,1,6,9,6,2,0,1,7,5,6,2,5,3,5,0,3,2,7,2,3,0,3,6,1,7,8,7,0,4,0,6,7,6,6,3,9,8,5,8,3,3,0,9,6,7,1,9,2,1,3,5,1,6,3,4,3,4,1,6,8,4,2,5
            // };
            // 笨蛋解法
            // M372SuperPow m372SuperPow = new M372SuperPow();
            // m372SuperPow.SuperPow(a, b);

            M372SuperPow2 m372SuperPow2 = new M372SuperPow2();
            Console.Write(m372SuperPow2.SuperPow(a, b));
        }

        /// <summary>
        /// 超简单，S 把 magazine 上的字符 record 一下，然后 遍历 randomNote 即可
        /// https://leetcode-cn.com/problems/ransom-note/
        /// </summary>
        public static void RansomNote()
        {
            string ransomNote = "aa";
            string magazine = "aab";
            S383RansomNote s383RansomNote = new S383RansomNote();
            s383RansomNote.CanConstruct(ransomNote,magazine);
        }
        

        /// <summary>
        /// S 超简单(个屁！好多坑！！！)
        /// https://leetcode-cn.com/problems/maximize-sum-of-array-after-k-negations/ 
        /// </summary>
        public static void MaximizeSumOfArrayAfterKNegations()
        {
            S1005MaximizeSumOfArrayAfterKNegations sumOfArrayAfterKNegations
                = new S1005MaximizeSumOfArrayAfterKNegations();
            // int[] input = new int[]
            // {
            //     2, -3, -1, 5, -4
            // };
            // int k = 2;
            // int[] input = new int[]
            // {
            //     4, 2, 3
            // };
            // int k = 1;
            // int[] input = new int[]
            // {
            //     -2, 9, 9, 8, 4
            // };
            // int k = 5;
            // int[] input = new int[]
            // {
            //     -8, 3, -5, -3, -5, -2
            // };
            // int k = 6;
            int[] input = new int[]
            {
                -4, -2, -3
            };
            int k = 4;
            sumOfArrayAfterKNegations.LargestSumAfterKNegations(input,k);
        }

        /// <summary>
        /// S 输出排名
        /// https://leetcode-cn.com/problems/relative-ranks/
        /// </summary>
        public static void FindRelativeRanks()
        {
            // S506RelativeRanks s506RelativeRanks = new S506RelativeRanks();
            // int[] scores = {10, 3, 8, 9, 4};
            // s506RelativeRanks.FindRelativeRanks(scores);
            
            S506RelativeRanks2 s506RelativeRanks = new S506RelativeRanks2();
            int[] scores = {10, 3, 8, 9, 4};
            s506RelativeRanks.FindRelativeRanks(scores);
        }

        /// <summary>
        /// S 找到最长连续子串
        /// https://leetcode-cn.com/problems/consecutive-characters/
        /// </summary>
        public static void MaxPower()
        {
            S1446ConsecutiveCharacters s1446ConsecutiveCharacters = new S1446ConsecutiveCharacters();
            // int output = s1446ConsecutiveCharacters.MaxPower("leetcode");
            int output = s1446ConsecutiveCharacters.MaxPower("ee");
            Console.Write(output);
        }

        /// <summary>
        /// H 减去基数，再 mod，注意数据范围
        /// https://leetcode-cn.com/problems/nth-digit/
        /// </summary>
        public static void NthDigit()
        {
            M400NthDigit m400NthDigit = new M400NthDigit();
            // Console.Write(m400NthDigit.FindNthDigit(3));
            Console.Write(m400NthDigit.FindNthDigit(1000000000));
        }

        /// <summary>
        /// H 如果要找第几大/小的元素，可以考虑优先队列
        /// https://leetcode-cn.com/problems/k-th-smallest-prime-fraction/
        /// </summary>
        public static void KthSmallestPrimeFraction()
        {
            // int[] input = {1, 2, 3, 5};
            // int k = 3;
            // int[] input = {1, 7};
            // int k = 1;
            int[] input = {1,19,97,101,107,163,191,251,271,641,661,787,811,919,1123,1567,1571,2239,2251,2309,2389,2467,2609,2837,2843,2861,2969,3001,3221,3361,3623,3691,3823,3833,4129,4519,4523,4733,4903,5297,5641,5749,6053,6101,6257,6301,6373,6389,6781,6917,6949,7151,7213,7307,7331,7349,7433,7481,7573,7649,7673,8369,8539,8573,8609,8663,8861,9137,9239,9533,9547,9923,10457,10499,10627,10781,10837,10861,10883,11177,11257,11393,11489,11777,11933,11969,12161,12263,12301,12517,13099,13267,13627,13649,13759,13789,13829,13913,13933,14143,14221,14419,14591,14627,14669,14923,15091,15497,15559,15581,15661,15731,16061,16067,16111,16141,16217,16661,16747,16981,17299,17573,17903,17957,18013,18517,18521,18859,19301,19333,19553,19571,19583,19717,19777,19841,19843,19963,20333,20483,20521,20563,20641,20731,20873,20897,21139,21143,21149,21379,21577,21701,21787,21839,22027,22367,22397,22433,22637,22691,22697,23159,23293,23369,23473,24029,24181,24407,24631,25037,25339,25367,25469,25951,26111,26203,26267,26423,26539,26641,26647,26693,26813,26981,27109,27449,27653,27883,28349,28477,28643,28661,28921,29243,29339,29483,29819,29851,29863,29917};
            int k = 17993;
            H786KthSmallestPrimeFraction h786KthSmallestPrimeFraction = new H786KthSmallestPrimeFraction();
            int[] array = h786KthSmallestPrimeFraction.KthSmallestPrimeFraction(input, k);
            Console.Write($"{array[0]},{array[1]}");
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