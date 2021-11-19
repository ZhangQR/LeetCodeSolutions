using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using static LeetCodeSolutions.Tools;

namespace LeetCodeSolutions
{
    public class S563BinaryTreeTilt
    {

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }

            public TreeNode(int[] input)
            {
                int length = input.Length;
                TreeNode[] treeNodes = new TreeNode[length];
                for (int i = 0; i < treeNodes.Length; i++)
                {
                    treeNodes[i] = new TreeNode();
                }
                for (int i = 0; i < length; i++)
                {
                    treeNodes[i].val = input[i];
                    if (2 * i + 2 <= length)
                    {
                        treeNodes[i].left = treeNodes[2 * i + 1];
                    }

                    if (2 * i + 3 <= length)
                    {
                        treeNodes[i].right = treeNodes[2 * i + 2];
                    }
                }

                val = treeNodes[0].val;
                left = treeNodes[0].left;
                right = treeNodes[0].right;
            }
        }

        public int FindTilt(TreeNode root)
        {
            GetTreeSum(ref root, 1);
            return GetTilt(root);
        }
        
        public int GetTilt(TreeNode sumTree)
        {
            int ret = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(sumTree);
            int length = queue.Count;
            while (length>0)
            {
                length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    var top = queue.Dequeue();
                    if (top != null)
                    {
                        Console.Write($"{top.val} ");
                        queue.Enqueue(top.left);
                        queue.Enqueue(top.right);
                        int left = top.left == null ? 0 : top.left.val;
                        int right = top.right == null ? 0 : top.right.val;
                        ret += Math.Abs(left - right);
                    }
                }

                length = queue.Count;
            }

            return ret;
        }


        public int GetTreeSum(ref TreeNode tree, int index)
        {
            if (tree == null)
            {
                return 0;
            }
            tree.val = tree.val +
                       GetTreeSum(ref tree.left, 2 * index) +
                       GetTreeSum(ref tree.right, 2 * index + 1);
            return tree.val;
        }

        public static void PrintBinaryTree(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int length = queue.Count;
            while (length > 0)
            {
                length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode top = queue.Dequeue();
                    if (top != null)
                    {
                        Log($"{top.val} ");
                        queue.Enqueue(top.left);
                        queue.Enqueue(top.right);
                    }
                }
                length = queue.Count;
            }
        }
    }
}