using ConsoleApp.Challenges.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashmap_left_join
{
    public class HashmapLeftJoin
    {
        public List<string> LeftJoin(Hashtable hashtable1, Hashtable hashtable2)
        {
            if(hashtable1.size == 0 || hashtable2.size == 0)
            {
                throw new Exception ("Hashtable is empty");
            }
            List<string> list = new List<string>();

            List<string> hashtable1keys = hashtable1.Keys();
            foreach (var key in hashtable1keys)
            {
                if (hashtable2.Contains(key))
                {
                 list.Add( "[" + key + ":" + hashtable1.Get(key).value + "," + hashtable2.Get(key).value + "]");
                }
                else
                {
                 list.Add( "[" + key + ":" + hashtable1.Get(key).value + "," + "null" + "]");
                }
            }
            return list;
        }
    }
}
