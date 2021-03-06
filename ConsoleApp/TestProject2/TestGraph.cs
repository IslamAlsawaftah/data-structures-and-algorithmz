using ConsoleApp.Challenges.graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class TestGraph
    {
        Graph graph = new Graph(true,true); 
        // Node can be successfully added to the graph
        //[Fact]
        //public void Test1()
        //{
        //    Vertex node = graph.AddNode(2);
        //    Assert.Contains(node,graph.GetNodes());

        //}
        ////An edge can be successfully added to the graph
        //[Fact]
        //public void Test2()
        //{
        //    Vertex vertex = graph.AddNode(1);
        //    Vertex vertex1 = graph.AddNode(2);

        //    graph.AddEdge(vertex, vertex1, 10);

        //    Assert.NotNull(vertex.edges);
        //}
        //// A collection of all nodes can be properly retrieved from the graph
        //[Fact]
        //public void Test3()
        //{
        //    Vertex vertex = graph.AddNode(1);
        //    Vertex vertex1 = graph.AddNode(2);
        //    Vertex vertex2 = graph.AddNode(3);
        //    List<Vertex> expected = new List<Vertex>() { vertex,vertex1,vertex2};
        //    Assert.Equal(expected,graph.GetNodes());
        //}
        //// All appropriate neighbors can be retrieved from the graph
        //[Fact]
        //public void Test4()
        //{
        //    Vertex vertex = graph.AddNode(1);
        //    Vertex vertex1 = graph.AddNode(2);
        //    Vertex vertex2 = graph.AddNode(3);
        //    graph.AddEdge(vertex, vertex1, 10);
        //    graph.AddEdge(vertex, vertex2, 10);
        //    var result = graph.GetNeighbors(vertex);
        //    Assert.Equal(2, result.Count);
        //}
        //// Neighbors are returned with the weight between nodes included
        //[Fact]
        //public void Test5()
        //{
        //    Vertex vertex = graph.AddNode(1);
        //    Vertex vertex1 = graph.AddNode(2);
        //    graph.AddEdge(vertex, vertex1, 50);
        //    Edge[] result = graph.GetNeighbors(vertex).ToArray();
        //    Assert.Equal(50, result[0].getWeight());
        //}
        //// The proper size is returned, representing the number of nodes in the graph

        //[Fact]
        //public void Test6()
        //{
        //    Vertex vertex = graph.AddNode(1);
        //    Vertex vertex1 = graph.AddNode(2);
        //    Vertex vertex2 = graph.AddNode(3);
        //    graph.AddEdge(vertex, vertex1, 10);
        //    graph.AddEdge(vertex, vertex2, 10);
        //    var result = graph.Size();
        //    Assert.Equal(3, result);
        //}
        //// A graph with only one node and edge can be properly returned

        //[Fact]
        //public void Test7()
        //{
        //    Vertex vertex = graph.AddNode(10);
        //    graph.AddEdge(vertex, vertex, 5);
        //    List<Vertex> result = graph.GetNodes();
        //    Assert.Equal(vertex, result.ToArray()[0]);
        //}
        //// An empty graph properly returns null
        //[Fact]
        //public void Test8()
        //{
        //    List<Vertex> result = graph.GetNodes();
        //    Assert.Null(result);
        //}
        //// Breadth First Testing
        //[Fact]
        //public void TestBreadthFirst1()
        //{
        //    graph.AddNode(1);
        //    graph.AddNode(2);
        //    Vertex vertex = new Vertex(1);
        //    Vertex vertex1 = new Vertex(2);
        //    graph.AddEdge(vertex, vertex1, 10);  
        //    List<Vertex> list = graph.BreadthFirst(vertex);
        //    List<Vertex> expected = new List<Vertex>{ vertex, vertex1};
        //    Assert.Equal(expected, list);
        //}
        //[Fact]
        //public void TestBreadthFirst2()
        //{
        //    graph.AddNode(1);
        //    Vertex vertex = new Vertex(1);
        //    List<Vertex> result = graph.BreadthFirst(vertex);
        //    Assert.Equal(1, result[0].value);
        //}
        //[Fact]
        //public void TestBreadthFirst3()
        //{
        //    graph.AddNode(1);
        //    Vertex vertex = new Vertex(1);
        //    graph.AddEdge(vertex, vertex, 1);
        //    List<Vertex> result = graph.BreadthFirst(vertex);
        //    Assert.Equal(1, result[0].edges[0].getEnd().value);
        //}
        [Fact]
        public void BussinesTrip1()
        {

            var ArendelleVertex = graph.AddNode("Arendelle");
            var MetrovilleVertex =  graph.AddNode("Metroville");
            var PandoraVertex = graph.AddNode("Pandora");

            graph.AddEdge(PandoraVertex, ArendelleVertex, 150);
            graph.AddEdge(ArendelleVertex, MetrovilleVertex, 99);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.Equal(249, graph.BusinessTrip(graph, arr));
        }
        [Fact]
        public void BussinesTrip2()
        {
            var PandoraVertex = graph.AddNode("Pandora");
            var ArendelleVertex = graph.AddNode("Arendelle");
            graph.AddEdge(PandoraVertex, ArendelleVertex, 0);
            string[] arr = { };
            Assert.Null(graph.BusinessTrip(graph, arr));

        }
        [Fact]
        public void BussinesTrip3()
        {
            var ArendelleVertex = graph.AddNode("Arendelle");
            var MetrovilleVertex = graph.AddNode("Metroville");
            var PandoraVertex = graph.AddNode("Pandora");

            graph.AddEdge(PandoraVertex, ArendelleVertex, 150);
            graph.AddEdge(ArendelleVertex, MetrovilleVertex, 99);

            string[] arr = { "Pandora", "Arendelle", "Metroville" };
            Assert.NotEqual(250, graph.BusinessTrip(graph, arr));
        }
        //// Depth First Testing

        [Fact]
        public void TestDepthFirst1()
        {
            var vertex = graph.AddNode("A");
            var vertex1 = graph.AddNode("B");
            var vertex2 = graph.AddNode("C");
            var vertex3 = graph.AddNode("D");


            graph.AddEdge(vertex, vertex3, 10);
            graph.AddEdge(vertex, vertex1, 10);

            graph.AddEdge(vertex1, vertex3, 10);
            graph.AddEdge(vertex1, vertex2, 10);


            List<Vertex> list = graph.DepthFirst( vertex);
            List<Vertex> expected = new List<Vertex> { vertex, vertex3, vertex1,vertex2};
            Assert.Contains(expected[2], list);
        }
        [Fact]
        public void TestDepthFirst2()
        {
            var vertex = graph.AddNode("A");
            List<Vertex> result = graph.DepthFirst(vertex);
            Assert.Equal("A", result[0].value);
        }
        [Fact]
        public void TestDepthFirst3()
        {
            var vertex = graph.AddNode("A");
            graph.AddEdge(vertex, vertex, 1);
            List<Vertex> result = graph.DepthFirst( vertex);
            Assert.Equal("A", result[0].edges[0].getEnd().value);
        }
    }
}
