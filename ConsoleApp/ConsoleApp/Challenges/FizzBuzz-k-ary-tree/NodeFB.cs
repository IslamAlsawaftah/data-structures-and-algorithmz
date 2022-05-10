using System;
using System.Collections.Generic;

namespace ConsoleApp.Challenges.binary_tree_and_bst
{
    public class NodeFB
    {
        public object Value;
        public List<NodeFB> Children;

        public NodeFB(object value)
        {
            Value = value;
            Children = new List<NodeFB>();
        }
        public void AddChild(object value)
        {
           var nodefb= new NodeFB(value);
           Children.Add(nodefb);
        }
    }
}