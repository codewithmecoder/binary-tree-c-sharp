using BinaryTree.Problems.DepthFirstValue;

namespace BinaryTree.Problems.BreadthFirstValues;

public static class BreadthFirstValuesSolution
{
    public static void BreadthFirst(DepthFirstValueNode root)
    {
        var result = BreadthFirstValue(root);
        MyConsole(result);
    }

    private static List<string> BreadthFirstValue(DepthFirstValueNode root)
    {
        List<string> result = new();
        if (root != null)
        {
            List<DepthFirstValueNode> stack = new(new DepthFirstValueNode[] { root });

            while (stack.Count > 0)
            {
                var current = stack[0];
                stack.RemoveAt(0);
                if (!string.IsNullOrEmpty(current.Val)) result.Add(current.Val);
                if (current.Left != null) stack.Add(current.Left);
                if (current.Right != null) stack.Add(current.Right);
            }
        }
        return result;
    }

    private static void MyConsole(List<string> result)
    {
        if (result.Count > 0)
        {
            var strPrint = "";
            int index = 0;
            foreach (var r in result)
            {
                strPrint += index == 0 ? r : "," + r;
                index++;
            }
            Console.WriteLine("Breadth First Value: {0}", strPrint);
        }
        else
        {
            Console.WriteLine("Breadth First Value: Root null");
        }
    }
}
