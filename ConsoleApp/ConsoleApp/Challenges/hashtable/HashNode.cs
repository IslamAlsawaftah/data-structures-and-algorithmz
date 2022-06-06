using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashtable
{
    public class HashNode<K, V>
	{
        public K key;
        public V value;
        // Reference to next node
        public HashNode<K, V> next;

        // Constructor
        public HashNode(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
