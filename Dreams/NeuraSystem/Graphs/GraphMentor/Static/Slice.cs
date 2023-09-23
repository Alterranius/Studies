using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphMentor.Static
{
    public abstract class Slice
    {
        public SortedSet<NodeTuple> M_Tuples = new SortedSet<NodeTuple>();
        public SortedSet<NodeTuple> R_Tuples = new SortedSet<NodeTuple>();
        public SortedSet<NodeTuple> S_Tuples = new SortedSet<NodeTuple>();
        public SortedSet<NodeTuple> Tuples
        {
            get 
            {
                SortedSet<NodeTuple> result = new SortedSet<NodeTuple>();
                result.UnionWith(M_Tuples);
                result.UnionWith(R_Tuples);
                result.UnionWith(S_Tuples);
                return result;
            }
            private set {}
        }
        public SortedSet<NodeTuple> Input = new SortedSet<NodeTuple>();
        public SortedSet<NodeTuple> Output = new SortedSet<NodeTuple>();

        public Queue<Node> ToComplete = new Queue<Node>();

        public HashSet<NodeTuple> GetM_Neighbours(Node node)
        {
            return M_Tuples.Where(x => x.Node.Equals(node)).ToHashSet();
        }

        public HashSet<NodeTuple> GetS_Neighbours(Node node)
        {
            return S_Tuples.Where(x => x.Node.Equals(node)).ToHashSet();
        }

        public HashSet<NodeTuple> GetR_Neighbours(Node node)
        {
            return R_Tuples.Where(x => x.Node.Equals(node)).ToHashSet();
        }

        public void M_RankUp(Node root, Node node)
        {
            NodeTuple nodeTuple = M_Tuples.FirstOrDefault(x => x.Node.Equals(root) && x.Root.Equals(node));
            M_Tuples.Remove(nodeTuple);
            S_Tuples.Add(nodeTuple);
        }

        public void R_RankUp(Node root, Node node)
        {
            NodeTuple nodeTuple = R_Tuples.FirstOrDefault(x => x.Node.Equals(root) && x.Root.Equals(node));
            R_Tuples.Remove(nodeTuple);
            S_Tuples.Add(nodeTuple);
        }
    }
}
