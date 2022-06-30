
namespace InlämningDatalogiME
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
    {
        public Node<T>? Root = null; //denna ska va private egentligen. Den är public för Print
        public int Size = 0;


        public int Count()
        {
            return Size;
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
            if (Root == null) { Root = node; Size++; return; }

            var current = Root;

            while (true)
            {
                if (current.Data.CompareTo(value) < 0)
                {
                    if (current.RightChild != null) current = current.RightChild;

                    else { current.RightChild = node; Size++; return; } //If end is reached, add node 
                }
                else
                {
                    if (current.LeftChild != null) current = current.LeftChild; //If end is reached, add node 

                    else { current.LeftChild = node; Size++;  return; }
                }
            }
        }

        public void Print(Node<T> node) //https://kalkicode.com/insertion-in-binary-search-tree-without-recursion-in-csharp
        {
            if (node != null)
            {
                // Visit to left subtree
                this.Print(node.LeftChild);
                // Display node value
                if (node == Root) Console.Write("  [" + node.Data +"]");
                else Console.Write("  " + node.Data);
                // Visit to right subtree
                this.Print(node.RightChild);
            }
        }

        public void Printe()
        {
            Queue<Node<T>?> nodes = new Queue<Node<T>?>();
            Queue<Node<T>?> newNodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            int depth = 0;

            bool exitCondition = false;
            while (nodes.Count > 0 && !exitCondition)
            {
                depth++;
                newNodes = new Queue<Node<T>?>();

                string xs = "[";
                foreach (var maybeNode in nodes)
                {
                    string data = maybeNode == null ? " " : "" + maybeNode.Data;
                    if (maybeNode == null)
                    {
                        xs += "_, ";
                        newNodes.Enqueue(null);
                        newNodes.Enqueue(null);
                    }
                    else
                    {
                        Node<T> node = maybeNode;
                        string s = node.Data.ToString();
                        xs += s.Substring(0, Math.Min(4, s.Length)) + ", ";
                        if (node.LeftChild != null) newNodes.Enqueue(node.LeftChild);
                        else newNodes.Enqueue(null);
                        if (node.RightChild != null) newNodes.Enqueue(node.RightChild);
                        else newNodes.Enqueue(null);
                    }
                }
                xs = xs.Substring(0, xs.Length - 2) + "]";

                Console.WriteLine(xs);

                nodes = newNodes;
                exitCondition = true;
                foreach (var m in nodes)
                {
                    if (m != null) exitCondition = false;
                }
            }
        }
    }
}