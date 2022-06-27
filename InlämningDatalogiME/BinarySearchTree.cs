
namespace InlämningDatalogiME
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
    {
        public Node<T>? Root = null;

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Exists(T value)
        {
            var current = Root;
            while (true)
            {
                if (current.Data.CompareTo(value) == 0) return true; //if current == value, return true

                if (current.Data.CompareTo(value) < 0)
                {
                    if ( current.RightChild != null) current = current.RightChild;

                    else return true; //If end is reached and nothing is found, return false
                }
                else
                {
                    if (current.LeftChild != null) current = current.LeftChild;

                    else return false; //If end is reached and nothing is found, return false
                }
            }
        }

        public void Insert(T value)
        {
            var node = new Node<T>(value);
            if (Root == null) { Root = node; return; }

            var current = Root;

            while (true)
            {
                if (current.Data.CompareTo(value) < 0)
                {
                    if (current.RightChild != null) current = current.RightChild;

                    else { current.RightChild = node; return; } //If end is reached, add node 
                }
                else
                {
                    if (current.LeftChild != null) current = current.LeftChild; //If end is reached, add node 

                    else { current.LeftChild = node; return; }
                }
            }
        }

        public void Print(Node<T> node)
        {
            if (node != null)
            {
                // Visit to left subtree
                this.Print(node.LeftChild);
                // Display node value
                Console.Write("  " + node.Data);
                // Visit to right subtree
                this.Print(node.RightChild);
            }
        }
    }
}