namespace ListaDuplamenteEncadeada
{
    public class DoublyLinkedList
    {
        private Node? head;
        private Node? tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtTail(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
        }

        public void Delete(int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: List is empty");
                return;
            }
            Node current = head;
            while (current != null)
            {
                if (current.data == data)
                {
                    if (current == head)
                    {
                        head = current.next;
                        if (head != null)
                        {
                            head.prev = null;
                        }
                        else
                        {
                            tail = null;
                        }
                    }
                    else if (current == tail)
                    {
                        tail = current.prev;
                        tail.next = null;
                    }
                    else
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev;
                    }
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("Error: Element not found");
        }

        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}