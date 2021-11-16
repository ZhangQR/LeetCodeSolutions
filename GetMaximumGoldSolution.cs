using System.Collections;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    class Tree
    {
        public int leftIndex;
        public int rightIndex;
        public int upIndex;
        public int downIndex;
        public int currentIndex;
        public int currentNumber;

        public Tree()
        {
            leftIndex = -1;
            rightIndex = -1;
            upIndex = -1;
            downIndex = -1;
            currentIndex = -1;
        }

        // public override string ToString()
        // {
        //     return $":{currentIndex},{leftIndex},{rightIndex},{upIndex},{downIndex}";
        // }
    }

    struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /// <summary>
    /// https://leetcode-cn.com/problems/path-with-maximum-gold/
    /// </summary>
    public class GetMaximumGoldSolution
    {
        private Tree[] trees;
        private Stack<int> path;

        public int GetMaximumGold(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            trees = new Tree[m * n];
            path = new Stack<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trees[TranformToOneIndex(i, j, m, n)] = new Tree()
                    {
                        currentNumber = grid[i][j],
                        currentIndex = GetAroundIndex(new Vector2(0, 0), i, j, m, n),
                        leftIndex = GetAroundIndex(new Vector2(0, -1), i, j, m, n),
                        rightIndex = GetAroundIndex(new Vector2(0, 1), i, j, m, n),
                        upIndex = GetAroundIndex(new Vector2(-1, 0), i, j, m, n),
                        downIndex = GetAroundIndex(new Vector2(1, 0), i, j, m, n),
                    };
                }
            }

            int ret = 0;
            for (int i = 0; i < n * m; i++)
            {
                int newPathResult = DepthFirstSearch(trees[i]);
                path.Clear();
                if (ret < newPathResult)
                {
                    ret = newPathResult;
                }
            }

            return ret;
        }

        private int TranformToOneIndex(int i, int j, int m, int n)
        {
            return i * n + j;
        }

        int DepthFirstSearch(Tree tree)
        {
            if (tree == null || tree.currentNumber == 0 || path.Contains(tree.currentIndex))
            {
                return 0;
            }

            //  Debug.Log(step++ + tree.ToString());
            path.Push(tree.currentIndex);
            int left = 0, right = 0, down = 0, up = 0;
            left = DepthFirstSearch(GetTree(tree.leftIndex));
            right = DepthFirstSearch(GetTree(tree.rightIndex));
            up = DepthFirstSearch(GetTree(tree.upIndex));
            down = DepthFirstSearch(GetTree(tree.downIndex));

            int ret = GetMax(left, right, up, down) + tree.currentNumber;
            path.Pop();
            // Debug.Log(tree.currentIndex + " ::: " + ret);
            return ret;
        }

        private int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }

        Tree GetTree(int index)
        {
            return index >= 0 ? trees[index] : null;
        }

        int GetAroundIndex(Vector2 direction, int i, int j, int m, int n)
        {
            Vector2 nowIndex = new Vector2(i + direction.x, j + direction.y);
            if (nowIndex.x < 0 || nowIndex.y < 0 ||
                nowIndex.x >= m || nowIndex.y >= n)
            {
                return -1;
            }

            return TranformToOneIndex(nowIndex.x, nowIndex.y, m, n);
        }
    }
}