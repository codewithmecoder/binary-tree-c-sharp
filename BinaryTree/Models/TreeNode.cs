namespace BinaryTree.Models;

public class TreeNode
{
    public int Val { get; set; }
    public TreeNode? Right { get; set; }
    public TreeNode? Left { get; set; }

    public TreeNode(int val, TreeNode? right = null, TreeNode? left = null)
    {
        Val = val;
        Right = right;
        Left = left;
    }
}
