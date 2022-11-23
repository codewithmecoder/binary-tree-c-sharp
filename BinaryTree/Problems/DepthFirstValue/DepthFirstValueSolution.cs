using System.ComponentModel.Design.Serialization;

namespace BinaryTree.Problems.DepthFirstValue;

public static class DepthFirstValueSolution
{

    public static void DepthFirstValueIterate(DepthFirstValueNode root)
    {
        var result = DepthFirstValue(root);
        MyConsole(result);
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
            Console.WriteLine("Depth First Value: {0}", strPrint);
        }
        else
        {
            Console.WriteLine("Depth First Value: Root null");
        }
    }

    private static List<string> DepthFirstValue(DepthFirstValueNode root)
    {
        List<string> result = new();
        if (root != null)
        {
            Stack<DepthFirstValueNode> stack = new(new DepthFirstValueNode[] { root });

            while (stack.Count > 0)
            {
                var r = stack.Pop();
                if (!string.IsNullOrEmpty(r.Val)) result.Add(r.Val);
                if (r.Right != null) stack.Push(r.Right);
                if (r.Left != null) stack.Push(r.Left);
            }
        }
        return result;
    }
}


public class DepthFirstValueNode
{
    public string? Val { get; set; }
    public DepthFirstValueNode? Right { get; set; }
    public DepthFirstValueNode? Left { get; set; }

    public DepthFirstValueNode(
        string? val,
        DepthFirstValueNode? right = null,
        DepthFirstValueNode? left = null)
    {
        Val = val;
        Right = right;
        Left = left;
    }
}
