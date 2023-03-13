// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var linkedList = new LinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.Remove(2);

foreach (var item in linkedList)
    Console.WriteLine(@$"valor:{item}");