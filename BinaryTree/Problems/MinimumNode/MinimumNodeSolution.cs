namespace BinaryTree.Problems.TreeSums;

public static class MinimumNodeSolution
{
    private static int MinIterate(NodeInt? root)
    {
        int result = int.MaxValue;
        if (root != null)
        {
            List<NodeInt> stack = new(new NodeInt[] { root });

            while (stack.Count > 0)
            {
                var current = stack[0];
                stack.RemoveAt(0);
                if(current.Val < result) result = current.Val;
                if (current.Left != null) stack.Add(current.Left);
                if (current.Right != null) stack.Add(current.Right);
            }
        }
        return result;
    }
    private static int MinRecur(NodeInt? root)
    {
        if(root == null) return int.MaxValue;
        var min = Math.Min(MinRecur(root.Left), MinRecur(root.Right));
        return Math.Min(root.Val, min);
    }

    public static void MinIteration(NodeInt? root)
    {
        var result = MinIterate(root);
        Console.WriteLine(result);
    }

    public static void MinRecursive(NodeInt? root)
    {
        var result = MinRecur(root);
        Console.WriteLine(result);
    }
}

