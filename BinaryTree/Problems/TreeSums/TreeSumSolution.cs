namespace BinaryTree.Problems.TreeSums;

public static class TreeSumSolution
{
    private static int TreeSumIterate(NodeInt? root)
    {
        int result = 0;
        if (root != null)
        {
            List<NodeInt> stack = new(new NodeInt[] { root });

            while (stack.Count > 0)
            {
                var current = stack[0];
                stack.RemoveAt(0);
                result += current.Val;
                if (current.Left != null) stack.Add(current.Left);
                if (current.Right != null) stack.Add(current.Right);
            }
        }
        return result;
    }
    private static int TreeSumRecur(NodeInt? root)
    {
        if(root == null) return 0;
        return root.Val + TreeSumRecur(root.Left) + TreeSumRecur(root.Right);
    }

    public static void TreeSumIteration(NodeInt? root)
    {
        var result = TreeSumIterate(root);
        Console.WriteLine(result);
    }

    public static void TreeSumRecursive(NodeInt? root)
    {
        var result = TreeSumRecur(root);
        Console.WriteLine(result);
    }
}

public class NodeInt
{
    public int Val { get; set; }
    public NodeInt? Right { get; set; }
    public NodeInt? Left { get; set; }

    public NodeInt(
        int val,
        NodeInt? right = null,
        NodeInt? left = null)
    {
        Val = val;
        Right = right;
        Left = left;
    }
}