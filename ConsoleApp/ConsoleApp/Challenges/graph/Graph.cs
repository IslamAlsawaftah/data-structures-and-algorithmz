using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Challenges.graph
{
    public class Graph
    {
        private List<Vertex> vertices;
        private bool isWeighted;
        private bool isDirected;
        public Graph(bool inputIsWeighted, bool inputIsDirected)
        {
            this.vertices = new List<Vertex>();
            this.isWeighted = inputIsWeighted;
            this.isDirected = inputIsDirected;
        }
        public Vertex AddNode(string val)
        {
            Vertex newvertex = new Vertex(val);
            vertices.Add(newvertex);
            return newvertex;
        }
        public void AddEdge(Vertex vertex1, Vertex vertex2, int weight)
        {
            if (!this.isWeighted)
            {
                weight = (int)(int?)null;
            }
            vertex1.addEdge(vertex2, weight);
            if (!this.isDirected)
            {
                vertex2.addEdge(vertex1, weight);
            }
        }
        public List<Vertex> GetNodes()
        {
            if (vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return vertices;

            }
        }
        public List<Edge> GetNeighbors(Vertex node)
        {
            var neighbors =  vertices.Find(v => v.value == node.value).edges;
            return neighbors;
        }
        public int Size()
        {
            return vertices.Count;
        }

        public void PrintGraph(List<int>[] adj, int V)
        {
            for (int v = 0; v < V; ++v)
            {
                Console.Write("vertex " + v + " ");
                foreach (int x in adj[v])
                    Console.Write("-> " + x);
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public List<Vertex> BreadthFirst(Vertex vertex)
        {
            List<Vertex> visitedVertices = new List<Vertex>();
            Queue<Vertex> visitQueue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            visitQueue.Enqueue(vertex);
            visited.Add(vertex);
            if (visitQueue.Count == 0)
            {
                throw new Exception("no nodes added");
            }
            while (visitQueue.Count != 0)
            {
                Vertex front = visitQueue.Dequeue();
                visitedVertices.Add(front);
                foreach (Edge child in ((Vertex)front).edges)
                {
                    Vertex neighbor = child.getEnd();
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        visitQueue.Enqueue(neighbor);
                    }
                }
            }
            return visitedVertices;
        }
        public Vertex GetVertexByValue(string value)
        {
            foreach (Vertex vertex in vertices)

            {
                if (vertex.value == value)
                {
                    return vertex;
                }
            }
            return null;
        }
        public int? BusinessTrip(Graph graph, string[] cities)
        {
            var total = 0;
            for (int i = 0; i < cities.Length - 1; i++)
            {
                Vertex vertex = graph.GetVertexByValue(cities[i]);
                List<Edge> neighbors = graph.GetNeighbors(vertex);
                for (var j = 0; j < neighbors.Count; j++)
                {
                    if (neighbors[j].getStart().value == vertex.value)
                    {
                        total += neighbors[j].getWeight();
                    }
                }
            }
            if (total == 0)
            {
                return null;
            }
            else
            {
                return total;
            }
        }
        public List<Vertex> DepthFirst(Vertex root)
        {
            List<Vertex> visited = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(root);
            visited.Add(root);
            while (stack.Count != 0)
            {
                Vertex vertex = stack.Pop();

                    foreach (Edge edge in GetNeighbors(vertex))
                    {
                    Vertex neighbor = edge.getEnd();

                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        stack.Push(neighbor);
                    }
                }
            }
            return visited;
        }
    }
}