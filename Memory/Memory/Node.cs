using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    internal class Node
    {
        public string Id { get; set; }
        public string ChainId { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }
        public bool IsLeaf { get; set; }
        public bool IsRoot { get; set; }
        public bool IsFile { get; set; }
    }
}
