namespace BinaryTreeComparison.Data
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int val)
        {
            Value = val;
        }
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
}
