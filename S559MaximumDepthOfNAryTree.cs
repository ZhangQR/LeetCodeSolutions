using System.Collections;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class S559MaximumDepthOfNAryTree
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public List<Node> children;

            public Node()
            {
            }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, List<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
        
        public int MaxDepth(Node root)
        {
            return DFS(root);
        }

        public int DFS(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.children.Count == 0)
            {
                return 1;
            }

            int max = 0;
            foreach (Node child in node.children)
            {
                int now = DFS(child) + 1;
                if (now > max)
                {
                    max = now;
                }
            }

            return max;
        }
    }
}