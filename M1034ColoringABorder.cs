using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class M1034ColoringABorder
    {
        private int[,] direction = new int[4, 2]
        {
            {-1, 0},     // 上
            {1, 0},    // 下
            {0, -1},    // 左
            {0, 1}      // 右
        };
        private bool[][] record;
        private int totalRow, totalCol;
        public int[][] ColorBorder(int[][] grid, int row, int col, int color)
        {
            totalRow = grid.Length;
            totalCol = grid[0].Length;
            record = new bool[totalRow][];
            for (int i = 0; i < totalRow; i++)
            {
                record[i] = new bool[totalCol];
            }
            List<KeyValuePair<int, int>> needPainted = new List<KeyValuePair<int, int>>();
            Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
            queue.Enqueue(new KeyValuePair<int, int>(row,col));
            bool paintCrt = false;
            while (queue.Count > 0)
            {
                // paintCrt = false;
                var crt = queue.Dequeue();
                record[crt.Key][crt.Value] = true;
                var upIndex = new KeyValuePair<int, int>(crt.Key + direction[0, 0], crt.Value + direction[0, 1]);
                var downIndex = new KeyValuePair<int, int>(crt.Key + direction[1, 0], crt.Value + direction[1, 1]);
                var leftIndex = new KeyValuePair<int, int>(crt.Key + direction[2, 0], crt.Value + direction[2, 1]);
                var rightIndex = new KeyValuePair<int, int>(crt.Key + direction[3, 0], crt.Value + direction[3, 1]);
                // 这里不能用 || ，不然会短路
                if (DirectionProcess(in upIndex, in crt, ref grid, ref queue) |
                    DirectionProcess(in downIndex, in crt, ref grid, ref queue) |
                    DirectionProcess(in leftIndex, in crt, ref grid, ref queue) |
                    DirectionProcess(in rightIndex, in crt, ref grid, ref queue))
                    // grid[crt.Key][crt.Value] = color;
                    needPainted.Add(crt);
            }
            
            // 最后一起涂待涂色的部分，提前涂的话会出问题
            foreach (var (key,value) in needPainted)
            {
                grid[key][value] = color;
            }
            return grid;
        }

        /// <summary>
        /// 处理一个方向上的操作
        /// </summary>
        /// <param name="nextIndex"></param>
        /// <param name="crtIndex"></param>
        /// <param name="grid"></param>
        /// <param name="queue"></param>
        /// <returns> 是否绘制当前格子为 color </returns>
        private bool DirectionProcess(in KeyValuePair<int,int> nextIndex,
            in KeyValuePair<int,int> crtIndex,ref int[][] grid,ref Queue<KeyValuePair<int, int>> queue)
        {
            
            if (!CheckBorder(nextIndex) &&  
                grid[nextIndex.Key][nextIndex.Value] == grid[crtIndex.Key][crtIndex.Value])
            {
                if (!record[nextIndex.Key][nextIndex.Value])
                {
                    queue.Enqueue(nextIndex);    
                }
                return false;
            }
            return true;
        }

        private bool CheckBorder(KeyValuePair<int,int> index)
        {
            if (index.Key < 0 || index.Key >= totalRow || index.Value < 0 || index.Value >= totalCol)
            {
                return true;
            }
            return false;
        }
    }
}