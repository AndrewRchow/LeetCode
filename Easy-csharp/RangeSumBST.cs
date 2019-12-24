using System;

namespace Easy_csharp
{
    public static class RangeSumBST
    {
        public static int output;
        public static int Solution(TreeNode root, int L, int R)
        {
            output = 0;
            DFS(root,L,R);
            return output;
        }

        public static void DFS(TreeNode node, int L, int R)
        {
            if (node != null)
            {
                if (L <= node.val && node.val <= R)
                    output += node.val;
                if (L < node.val)
                    DFS(node.left, L, R);
                if (node.val< R)
                    DFS(node.right, L, R);
            }
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
