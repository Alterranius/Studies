using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public class NodeTuple
    {
        public Node Root { get; set; }
        public Node Node { get; set; }
        public decimal Range { get; set; }
        public NodeTuple(Node root, Node node)
        {
            Root = root;
            Node = node;
        }
    }
}
