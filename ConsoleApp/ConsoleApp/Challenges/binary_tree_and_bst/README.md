# Tree 

A tree data structure is a non-linear data structure because it does not store in a sequential manner. It is a hierarchical structure as elements in a Tree are arranged in multiple levels. In the Tree data structure, the topmost node is known as a root node. Each node contains some data, and data can be of any type.

# Challenge Summary

Binary Tree and Binary Search Tree Implementation

# Approach & Efficiency

BinaryTree Traversal : O(n)

BinarySearchTree Add and Contains: O(Log n)

# API

### Binary Tree

Create a Binary Tree class.

Create Node class.

Define a method for each of the depth first traversals:

#### Pre order: 

1- Visit root node

2- Visit all the nodes in the left subtree

3- Visit all the nodes in the right subtree

#### In order

1- First, visit all the nodes in the left subtree

2- Then the root node

3- Visit all the nodes in the right subtree

#### Post order 

1- Visit all the nodes in the left subtree

2- Visit all the nodes in the right subtree

3- Visit the root node

returns an array of the values, ordered appropriately.

Any exceptions or errors that come from code should be handeld

### Binary Search Tree

Create a Binary Search Tree class inherit of the Binary Tree Class, with the following additional methods:

Add: Adds a new node with that value in the correct location in the binary search tree.

Contains: returns boolean indicating whether or not the value is in the tree at least once.