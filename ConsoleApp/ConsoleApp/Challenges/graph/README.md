# Graphs

A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph.

A Graph consists of a finite set of vertices(or nodes) and set of Edges which connect a pair of nodes.

# Challenge

Graph implementation with folloing methods : 

* AddNode 

* AddEdge

* GetNodes

* GetNeighbors

* Size

# Approach & Efficiency

| Method      | Time Complexity | Space Complexity
| ----------- | ----------- | ----------- |
| AddNode     |    O(1)   | O(1) |
| AddEdge     |    O(1)   | O(1) |
| GetNodes    |    O(n)   | O(n) |
| GetNeighbors|    O(n)   | O(1) |
| Size        |    O(1)   | O(1) |

# API


1- add node

Arguments: value

Returns: The added node

Add a node to the graph

2- add edge

Arguments: 2 nodes to be connected by the edge, weight (optional)

Returns: nothing

Adds a new edge between two nodes in the graph

If specified, assign a weight to the edge

Both nodes should already be in the Graph

3- get nodes

Arguments: none

Returns all of the nodes in the graph as a collection (set, list, or similar)

4- get neighbors

Arguments: node

Returns a collection of edges connected to the given node

Include the weight of the connection in the returned collection

5- size

Arguments: none

Returns the total number of nodes in the graph