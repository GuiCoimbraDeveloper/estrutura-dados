namespace ArvoreBinaria
{
    public class BinaryTree
    {
        private Node? root;

        public BinaryTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public Node Search(int data)
        {
            Node current = root;
            while (current != null)
            {
                if (data == current.data)
                {
                    return current;
                }
                else if (data < current.data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return null;
        }

        private void InorderTraversal(Node node)
        {
            if (node != null)
            {
                InorderTraversal(node.left);
                Console.Write(node.data + " ");
                InorderTraversal(node.right);
            }
        }

        public void PrintTree()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            InorderTraversal(root);
            Console.WriteLine();
        }
    }
}
