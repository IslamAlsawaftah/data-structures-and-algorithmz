using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashtable
{
    public class Hashtable<K, V>
    {

        List<HashNode<K, V>> bucket;
        int numBuckets;
        int size;
        public Hashtable()
        {
            bucket = new List<HashNode<K, V>>();
            for (int i = 0; i < numBuckets; i++)
            {
                bucket.Add(null);
            }
        }

        public void Set(K key, V value)
        {

            int index = GetBucketIndex(key);
            Console.WriteLine(index);
            HashNode<K, V> head = bucket[index];
            HashNode<K, V> toAdd = new HashNode<K,V>(key,value);
            toAdd.key = key;
            toAdd.value = value;
            if (head == null)
            {
                bucket.set(index, toAdd);
                size++;

            }
            else
            {
                while (head != null)
                {
                    if (head.key.Equals(key))
                    {
                        head.value = value;
                        size++;
                        break;
                    }
                    head = head.next;
                }
                if (head == null)
                {
                    head = bucket[index];
                    toAdd.next = head;
                    bucket.set(index, toAdd);
                    size++;
                }
            }
            if ((1.0 * size) / numBuckets > 0.7)
            {
                List<HashNode<K, V>> tmp = bucket;
                bucket = new List<HashNode < K, V >> ();
                numBuckets = 2 * numBuckets;
                for (int i = 0; i < numBuckets; i++)
                {
                    bucket.Add(null);
                }
                for (HashNode<K, V> headNode:tmp)
                {
                    while (headNode != null)
                    {
                        Set(headNode.key, headNode.value);
                        headNode = headNode.next;
                    }
                }


            }
        }
        private int GetBucketIndex(K key)
        {
            int hashCod = key.GetHashCode();
            return Math.Abs(hashCod % numBuckets);
        }
        public V Get(K key)
        {
            int index = GetBucketIndex(key);
            HashNode<K, V> head = bucket[index];
            while (head != null)
            {
                if (head.key.Equals(key))
                {
                    return head.value;
                }
                head = head.next;
            }
            return null;
        }
        public bool Contains(K key)
        {
            // Find head of chain for given key
            int bucketIndex = GetBucketIndex(key);
            int hashCode = key.GetHashCode();

            HashNode<K, V> head = bucket[bucketIndex];

            // Search key in chain
            while (head != null)
            {
                if (head.key.Equals(key))
                    return true;
                head = head.next;
            }

            // If key not found
            return false;
        }
        public List<K> Keys()
        {
        }
        private int Hash(K key)
        {
            int hashcode = key.GetHashCode();
            int index = hashcode % numBuckets;
            index = index < 0 ? index * -1 : index;
            return index;
        }
        // Every time a key is generated. The key is passed to a hash function.
        // hash code generated
        // (%) the hash code by the size of the hash table.
    }
}
