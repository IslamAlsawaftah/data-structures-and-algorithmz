using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashtable
{
    public class Hashtable
    {
        public HashNode[] Table; 
        public int size ;
        public Hashtable(int size)
        {
            this.size = size;
            Table = new HashNode[size];
        }

        public void Set(string key, string value)
        {
            int index = Hash(key);
            HashNode node = new HashNode(key, value);
            if (Table[index] == null)
            {
                Table[index] = node;
            }
            else
            {
                HashNode cur = Table[index];
                while (cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = new HashNode(key, value);
            }
        }
        public HashNode Get(string key)
        {
            int index = Hash(key);
            HashNode head = Table[index];
            while (head != null)
            {
                if (head.key.Equals(key))
                {
                    return head;
                }
                head = head.next;
            }
            return null;
        }
        public bool Contains(string key)
        {
            // Find head of chain for given key
            int index = Hash(key);
            HashNode head = Table[index];

            // Search key
            while (head != null)
            {
                if (head.key.Equals(key))
                    return true;
                head = head.next;
            }

            // If key not found
            return false;
        }
        public List<string> Keys()
        {
            List<string> keys = new List<string>();
            for (int i= 0; i< Table.Length; i++)
            {
                    HashNode current = Table[i];
                    while (current != null)
                    {
                        keys.Add(current.key);
                        current = current.next;
                    }
                }
            
            return keys;
        }
        public int Hash(string key)
        {
            int hashcode = 0;
            int index = hashcode * 599 % size;
            index = index < 0 ? index * -1 : index;
            return index;
        }
        // Every time a key is generated. The key is passed to a hash function.
        // hash code generated
        // (%) the hash code by the size of the hash table.
    }
}
