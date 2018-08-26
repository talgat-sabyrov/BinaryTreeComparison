using System;
using Autofac;
using BinaryTreeComparison.Abstractions;
using BinaryTreeComparison.Data;

namespace BinaryTreeComparison
{
    static class Program
    {
        private static readonly ITreeCompare TreeCompare;

        static Program()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                TreeCompare = scope.Resolve<ITreeCompare>();
            }
        }

        static void Main(string[] args)
        {
            var tree1 = new BinaryTreeNode(1)
            {
                Left = new BinaryTreeNode(2),
                Right = new BinaryTreeNode(2)
            };

            var tree2 = new BinaryTreeNode(1)
            {
                Left = new BinaryTreeNode(2),
                Right = new BinaryTreeNode(3)
            };

            Console.WriteLine(TreeCompare.IsSameTree(tree1, tree2) ? "Trees are equal!" : "Trees are not equal!");

            Console.Read();
        }
    }
}
