using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashtable
{
    public class HashNode
	{
        public int key;
        public string value;
        // Reference to next node
        public HashNode next;

        // Constructor
        public HashNode(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
