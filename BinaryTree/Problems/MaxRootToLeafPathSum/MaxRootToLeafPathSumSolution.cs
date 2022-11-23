using BinaryTree.Problems.TreeSums;

namespace BinaryTree.Problems.MaxRootToLeafPathSum;

public static class MaxRootToLeafPathSumSolution
{
    private static int MaxRootToLeafPathSumRecur(NodeInt? root)
    {
        if(root == null) return int.MinValue;
        if(root.Right == null && root.Left == null) return root.Val;
        return root.Val + Math.Max(MaxRootToLeafPathSumRecur(root.Right), MaxRootToLeafPathSumRecur(root.Left));
    }

    public static void MaxRootToLeafPathSumRecursive(NodeInt? root)
    {
        var result = MaxRootToLeafPathSumRecur(root);
        Console.WriteLine("Max Leaf Path Sum is : {0}", result);
    }
}
