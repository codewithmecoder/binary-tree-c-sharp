using BinaryTree.Problems.BreadthFirstValues;
using BinaryTree.Problems.DepthFirstValue;
using BinaryTree.Problems.TreeIncludes;
using BinaryTree.Problems.TreeSums;

DepthFirstValueNode depthFirstValueNode = new("a");
DepthFirstValueNode b = new("b");
DepthFirstValueNode c = new("c");
DepthFirstValueNode d = new("d");
DepthFirstValueNode e = new("e");
DepthFirstValueNode f = new("f");
depthFirstValueNode.Right = c;
c.Right = f;
depthFirstValueNode.Left = b;
b.Right = e;
b.Left = d;


NodeInt nodeInt = new(3);
NodeInt nodeInt1 = new(11);
NodeInt nodeInt2 = new(4);
NodeInt nodeInt3 = new(2);
NodeInt nodeInt4 = new(4);
NodeInt nodeInt5 = new(1);
nodeInt.Right = nodeInt1;
nodeInt.Left = nodeInt4;
nodeInt1.Left = nodeInt2;
nodeInt1.Right = nodeInt3;
nodeInt4.Left = nodeInt5;

//node
//DepthFirstValueSolution.DepthFirstValueIterate(depthFirstValueNode);
//BreadthFirstValuesSolution.BreadthFirst(depthFirstValueNode);
//TreeIncludeSolution.TreeIncludesIteration(depthFirstValueNode, "d");
//TreeIncludeSolution.TreeIncludesIteration(depthFirstValueNode, "f");
//TreeIncludeSolution.TreeIncludesIteration(depthFirstValueNode, "g");
//TreeIncludeSolution.TreeIncludesIteration(null, "h");

//TreeIncludeSolution.TreeIncludesResursive(depthFirstValueNode, "d");
//TreeIncludeSolution.TreeIncludesResursive(depthFirstValueNode, "f");
//TreeIncludeSolution.TreeIncludesResursive(depthFirstValueNode, "g");
//TreeIncludeSolution.TreeIncludesResursive(null, "h");


//TreeSumSolution.TreeSumIteration(nodeInt);
//TreeSumSolution.TreeSumIteration(null);

TreeSumSolution.TreeSumRecursive(nodeInt);
TreeSumSolution.TreeSumRecursive(null);
Console.WriteLine("Hello, World!");


