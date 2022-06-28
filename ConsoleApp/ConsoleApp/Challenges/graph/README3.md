# Challenge Summary

a function called business trip, return the cost of the trip (if it’s possible) or null (if not)

# Whiteboard Process

# Approach & Efficiency

* create a method called GetVertexByValue which is return a vertex

* create a method called BusinessTrip that will return a null if there is no way between given cities or cost for trip between these cities

* create a total variable initialize it ot 0, loop through cities

* get vertex by call GetVertexByValue method , craete list of edges to know neghibors for given vertex

  * loop thourgh neighbors , then check if given vertex have neighbors then increment total

* return null if total is 0

* else return total

### Big O represents the complexity of a function that increases linearly and in direct proportion to the number of inputs.

### Time: O(n^2)

### Space: O(1)

# Solution

to run the program : ctrl+F5

[Code](Graph.cs)