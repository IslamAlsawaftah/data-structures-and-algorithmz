# Stacks and Queues

### Stack is a linear data structure which follows a particular order in which the operations are performed. The order may be LIFO(Last In First Out) or FILO(First In Last Out).

### A Queue is a linear structure which follows a particular order in which the operations are performed. The order is First In First Out (FIFO). recently added; in a queue, we remove the item the least recently added.


### Challenge

#### Challenge Using a Linked List as the underlying data storage mechanism, implement both a Stack and a Queue

#### Create a Stack class that has a top property. It creates an empty Stack when instantiated.

#### Create a Queue class that has a front property. It creates an empty Queue when instantiated.

### Approach & Efficiency

* Stack.push and Queue.enqueue: Time O(1) / Space O(1)

* Stack.pop and Queue.dequeue: Time O(1) / Space O(1)

* Stack.peek and Queue.peek: Time O(1) / Space O(1)

* Stack.isEmpty and Queue.isEmpty: Time O(1) / Space O(1) 

### API


#### Stack Class:

* push: adds a new node with that value to the top of the stack.

* pop: Removes the node from the top of the stack

* peek: return value of the node located at the top of the stack

* is empty: returns boolean indicating whether or not the stack is empty.

#### Queue Class :

* enqueue: adds a new node with that value to the back of the queue.

* dequeue: Removes the node from the front of the queue

* peek: returns value of the node located at the front of the queue

* is empty: returns boolean indicating whether or not the queue is empty