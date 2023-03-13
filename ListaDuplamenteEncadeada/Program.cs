// See https://aka.ms/new-console-template for more information
using ListaDuplamenteEncadeada;

Console.WriteLine("Hello, World!");

DoublyLinkedList myLinkedList = new();
myLinkedList.InsertAtHead(10);
myLinkedList.InsertAtHead(20);
myLinkedList.InsertAtTail(30);
myLinkedList.PrintList(); // Output: 20 10 30
myLinkedList.Delete(10);
myLinkedList.PrintList(); // Output: 20 30