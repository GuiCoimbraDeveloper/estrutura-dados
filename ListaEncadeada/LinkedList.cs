namespace ListaEncadeada
{
    public class LinkedList<T>
    {
        private LinkedListNode<T>? _head;

        public void AddFirst(T value)
        {
            LinkedListNode<T> newNode = new(value);
            newNode.Next = _head;
            _head = newNode;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> newNode = new(value);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                LinkedListNode<T> currentNode = _head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public void Remove(T value)
        {
            if (_head == null)
            {
                return;
            }

            if (_head.Value.Equals(value))
            {
                _head = _head.Next;
                return;
            }

            LinkedListNode<T> currentNode = _head;
            while (currentNode.Next != null && !currentNode.Next.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }

            if (currentNode.Next != null)
            {
                currentNode.Next = currentNode.Next.Next;
            }
        }
    }
}
