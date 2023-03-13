// See https://aka.ms/new-console-template for more information
using Grafos;

Graph graph = new Graph(5);
graph.AddEdge(0, 1);
graph.AddEdge(1, 2);
graph.AddEdge(2, 3);
graph.AddEdge(3, 4);

List<int> adjList = graph.GetAdjList(1);
foreach (int v in adjList)
{
    Console.WriteLine(v);
}