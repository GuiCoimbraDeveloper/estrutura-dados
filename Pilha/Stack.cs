namespace Pilha
{
    public class Stack
    {
        private int[] stackArray;
        private int top;

        public Stack(int size)
        {
            stackArray = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Error: Stack is full");
                return;
            }
            stackArray[++top] = x;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: Stack is empty");
                return -1;
            }
            return stackArray[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Error: Stack is empty");
                return -1;
            }
            return stackArray[top];
        }
    }
}
