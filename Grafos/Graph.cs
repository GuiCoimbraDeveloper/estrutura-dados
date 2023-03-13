namespace Grafos
{
    public class Graph
    {
        private int V; // number of vertices
        private List<int>[] adj; // adjacency lists

        // constructor
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[V];
            for (int i = 0; i < V; i++)
            {
                adj[i] = new List<int>();
            }
        }

        // add an edge between two vertices
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        // get the adjacency list of a vertex
        public List<int> GetAdjList(int v)
        {
            return adj[v];
        }

        // get the number of vertices
        public int GetNumVertices()
        {
            return V;
        }
    }
}
