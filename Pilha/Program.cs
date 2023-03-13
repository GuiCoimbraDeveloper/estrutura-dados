// See https://aka.ms/new-console-template for more information
using Pilha;

Console.WriteLine("Hello, World!");
Stack myStack = new(5);
myStack.Push(10);
myStack.Push(20);
myStack.Push(30);
Console.WriteLine(myStack.Pop()); // Output: 30
Console.WriteLine(myStack.Peek()); // Output: 20
Console.WriteLine(myStack.Pop()); // Output: 20
Console.WriteLine(myStack.IsEmpty()); // Output: False