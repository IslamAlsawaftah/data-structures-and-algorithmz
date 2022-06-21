using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.graph
{
    public class Vertex
    {
        public int value { get; set; }
        public List<Edge> edges;

        public Vertex(int value)
        {
            this.value = value;
            this.edges = new List<Edge>();

        }
        public void addEdge(Vertex endVertex, int weight)
        {
            this.edges.Add(new Edge(this, endVertex, weight));
        }
    }
}
