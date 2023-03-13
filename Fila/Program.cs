// See https://aka.ms/new-console-template for more information
using Fila;

Console.WriteLine("Hello, World!");

Queue myQueue = new Queue(5);
myQueue.Enqueue(10);
myQueue.Enqueue(20);
myQueue.Enqueue(30);
Console.WriteLine(myQueue.Dequeue()); // Output: 10
Console.WriteLine(myQueue.Peek()); // Output: 20
Console.WriteLine(myQueue.Dequeue()); // Output: 20
Console.WriteLine(myQueue.IsEmpty()); // Output: False