using BinaryTree.Problems.DepthFirstValue;

namespace BinaryTree.Problems.TreeIncludes;

public static class TreeIncludeSolution
{
    private static bool TreeInclude(DepthFirstValueNode? root, string target)
    {
        if (root != null)
        {
            Stack<DepthFirstValueNode> stack = new(new DepthFirstValueNode[] { root });

            while (stack.Count > 0)
            {
                var r = stack.Pop();
                if(r.Val == target) return true;
                if (r.Right != null) stack.Push(r.Right);
                if (r.Left != null) stack.Push(r.Left);
            }
        }
        return false;
    }


    private static bool TreeIncludeRecu(DepthFirstValueNode? root, string target)
    {
        if(root == null) return false;
        if (root.Val == target) return true;
        return TreeIncludeRecu(root.Left, target) || TreeIncludeRecu(root.Right, target);
    }

    public static void TreeIncludesIteration(DepthFirstValueNode? root, string target)
    {
        var result = TreeInclude(root, target);
        if (result) Console.WriteLine("Target {0} is found", target);
        else Console.WriteLine("Target {0} is not found", target);
    }
    public static void TreeIncludesResursive(DepthFirstValueNode? root, string target)
    {
        var result = TreeIncludeRecu(root, target);
        if (result) Console.WriteLine("Target {0} is found", target);
        else Console.WriteLine("Target {0} is not found", target);
    }
}
