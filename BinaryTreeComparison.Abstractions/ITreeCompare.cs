using BinaryTreeComparison.Data;

namespace BinaryTreeComparison.Abstractions
{
    public interface ITreeCompare
    {
        bool IsSameTree(BinaryTreeNode btn1, BinaryTreeNode btn2);
    }
}
