
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
            var node = new Node<T>(value);
            var current = Root;
            if (Root == null)
            {
                Root = node;
            }

            else if (Root.Data.CompareTo(value) < 0) // root < value
            {
                while (current.Data.CompareTo(value) < 0 && current.RightChild != null)
                {
                    current = current.RightChild;
                }
                current.RightChild = node;
            }

            else  // root > value
            {
                while (current.Data.CompareTo(value) > 0 && current.LeftChild != null)
                {
                    current = current.LeftChild;
                }
                current.LeftChild = node;
            }
        }

        public void Print()
        {
            var current = Root;
            while (current != null)
            {
                current = current.LeftChild;
                if (current != null) Console.WriteLine(current.Data);
            }

            current = Root;
            Console.WriteLine(current.Data + " is root:");

            while (current != null)
            {
                current = current.RightChild;
                if (current != null) Console.WriteLine(current.Data);
            }
        }
    }
}