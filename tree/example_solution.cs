using System;

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
}

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }

    private bool IsValidBST(TreeNode node, long minVal, long maxVal)
    {
        if (node == null)
            return true;

        if (node.val <= minVal || node.val >= maxVal)
            return false;

        return IsValidBST(node.left, minVal, node.val) && IsValidBST(node.right, node.val, maxVal);
    }
}