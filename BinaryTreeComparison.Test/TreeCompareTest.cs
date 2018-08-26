using BinaryTreeComparison.Business;
using BinaryTreeComparison.Data;
using NUnit.Framework;

namespace BinaryTreeComparison.Test
{
    [TestFixture]
    public class TreeCompareTest
    {
        private TreeCompare _treeCompare;

        [SetUp]
        public void Init()
        {
            _treeCompare = new TreeCompare();
        }

        [Test]
        public void TreesAreEqual()
        {
            var tree1 = new BinaryTreeNode(1);
            tree1.Left = new BinaryTreeNode(2);
            tree1.Right = new BinaryTreeNode(2);
            tree1.Left.Left = new BinaryTreeNode(3);
            tree1.Left.Right = new BinaryTreeNode(3);
            tree1.Right.Left = new BinaryTreeNode(3);
            tree1.Right.Right = new BinaryTreeNode(3);

            var tree2 = new BinaryTreeNode(1);
            tree2.Left = new BinaryTreeNode(2);
            tree2.Right = new BinaryTreeNode(2);
            tree2.Left.Left = new BinaryTreeNode(3);
            tree2.Left.Right = new BinaryTreeNode(3);
            tree2.Right.Left = new BinaryTreeNode(3);
            tree2.Right.Right = new BinaryTreeNode(3);

            Assert.IsTrue(_treeCompare.IsSameTree(tree1, tree2)); 
        }

        [Test]
        public void TreesAreNotEqual()
        {
            var tree1 = new BinaryTreeNode(1);
            tree1.Left = new BinaryTreeNode(2);
            tree1.Right = new BinaryTreeNode(2);
            tree1.Left.Left = new BinaryTreeNode(4);
            tree1.Left.Right = new BinaryTreeNode(3);
            tree1.Right.Left = new BinaryTreeNode(3);
            tree1.Right.Right = new BinaryTreeNode(4);

            var tree2 = new BinaryTreeNode(1);
            tree2.Left = new BinaryTreeNode(2);
            tree2.Right = new BinaryTreeNode(2);
            tree2.Left.Left = new BinaryTreeNode(5);
            tree2.Left.Right = new BinaryTreeNode(3);
            tree2.Right.Left = new BinaryTreeNode(3);
            tree2.Right.Right = new BinaryTreeNode(5);

            Assert.IsFalse(_treeCompare.IsSameTree(tree1, tree2));
        }
    }
}
