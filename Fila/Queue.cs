namespace Fila
{
    public class Queue
    {
        private int[] queueArray;
        private int front;
        private int rear;
        private int size;

        public Queue(int size)
        {
            queueArray = new int[size];
            front = -1;
            rear = -1;
            this.size = size;
        }

        public bool IsEmpty()
        {
            return (front == -1 && rear == -1);
        }

        public bool IsFull()
        {
            return (rear == size - 1);
        }

        public void Enqueue(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Error: Queue is full");
                return;
            }
            else if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear++;
            }
            queueArray[rear] = x;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: Queue is empty");
                return -1;
            }
            int dequeuedElement = queueArray[front];
            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front++;
            }
            return dequeuedElement;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: Queue is empty");
                return -1;
            }
            return queueArray[front];
        }
    }
}
