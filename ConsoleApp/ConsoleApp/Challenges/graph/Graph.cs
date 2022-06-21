using System;
using System.Collections.Generic;

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
        public Vertex AddNode(int val)
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
            return vertices.Find(v => v.value == node.value).edges;
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
    }
}