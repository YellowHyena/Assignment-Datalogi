
namespace InlämningDatalogiME
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
    {
        private Node<T>? Root = null;

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Exists(T value)
        {
            throw new NotImplementedException();
        }

        public void Insert(T value)
        {
            if (Root == null) Root = new Node<T>(value); return;

        }

        public void Print()
        {
            Console.WriteLine(Root.Data);
        }
    }
}
