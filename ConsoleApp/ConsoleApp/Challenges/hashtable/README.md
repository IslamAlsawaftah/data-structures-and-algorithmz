# Hashtables

The Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection. It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally and then matches the hash code of the specified key at the time of accessing values.

# Challenge 

###  Implement a Hashtable Class

# Approach & Efficiency

### Get(K key):

Time Complexity: O(1)

Space Complexity: O(1)

### Set(K key, V value):

Time Complexity: O(1)

Space Complexity: O(1)

### Hash(K key):

Time Complexity O(n)

Space Complexity O(1)

### Contains(K key):

Time Complexity O(1)

Space Complexity O(1)

## API

1- Get(K key) : returns the value corresponding to the key if the key is present in HT (Hast Table)

2- Set(K key, V value) : adds new valid key, value pair to the HT, if already present updates the value

3- Hash(K key) : returns index in the collection for that key

4- Contains(K key) : returns boolean, indicating if the key exists in the table already.

5- Keys() : returns collection of keys

[Code](Hashtable.cs)