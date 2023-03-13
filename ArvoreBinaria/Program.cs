// See https://aka.ms/new-console-template for more information
using ArvoreBinaria;

Console.WriteLine("Hello, World!");

BinaryTree myTree = new();
myTree.Insert(10);
myTree.Insert(20);
myTree.Insert(5);
myTree.Insert(15);
myTree.PrintTree(); // Output: 5 10 15 20
Node searchResult = myTree.Search(15);
Console.WriteLine(searchResult.data); // Output: 15