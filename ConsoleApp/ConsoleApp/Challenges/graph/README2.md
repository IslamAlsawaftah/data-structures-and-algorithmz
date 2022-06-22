# Breadth-First Traversal of a Graph

## Challenge Summary

Implement a breadth-first traversal on a graph.

## Whiteboard Process

![](Whiteboard.png)

## Approach & Efficiency

### Time Complexity: O(n)

### Space Complexity: O(n)

## Solution

```
  public List<Vertex> BreadthFirst(Vertex vertex)
        {
            List<Vertex> visitedVertices = new List<Vertex>();
            visitedVertices.Add(vertex);
            Queue<Vertex> visitQueue = new Queue<Vertex>();
            visitQueue.Enqueue(vertex);
            while(visitQueue.Count != 0)
            {
                Vertex front = visitQueue.Dequeue();
                visitedVertices.Add(front);
                foreach(Edge child in front.edges)
                {
                    Vertex neighbor = child.getEnd();
                    if (!visitedVertices.Contains(neighbor))
                    {
                        //visitedVertices.Add(neighbor);
                        visitQueue.Enqueue(neighbor);
                    }
                }
            }
            return visitedVertices;
        }
```
