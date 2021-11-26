namespace LeetCodeSolutions
{
    public class S700SearchInABinarySearchTree
    {
        
        // Definition for a binary tree node.
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        
        public TreeNode SearchBST(TreeNode root, int val)
        {
            // return BinarySearch(root, val);
            while (root!=null && root.val!=val)
            {
                root = root.val < val ? root.left : root.right;
            }

            return root;
        }

        private TreeNode BinarySearch(TreeNode node,int value)
        {
            if (node == null)
            {
                return null;
            }
            if (value == node.val)
            {
                return node;
            }

            if (value < node.val)
            {
                return BinarySearch(node.left, value);
            }

            if (value > node.val)
            {
                return BinarySearch(node.right, value);
            }

            return null;
        }
        
    }
}