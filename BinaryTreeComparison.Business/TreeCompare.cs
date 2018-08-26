using BinaryTreeComparison.Abstractions;
using BinaryTreeComparison.Data;

namespace BinaryTreeComparison.Business
{
    public class TreeCompare : ITreeCompare
    {
        public bool IsSameTree(BinaryTreeNode btn1, BinaryTreeNode btn2)
        {
            if (btn1 == null && btn2 == null)
                return true;

            if (btn1 == null || btn2 == null)
                return false;

            var isLeftSame = IsSameTree(btn1.Left, btn2.Left);
            var isRightSame = IsSameTree(btn1.Right, btn2.Right);

            return btn1.Value == btn2.Value && isLeftSame && isRightSame;
        }
    }
}
