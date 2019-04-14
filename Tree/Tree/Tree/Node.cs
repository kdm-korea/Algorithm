using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public unsafe struct Node
    {
        public int data;
        public Node* rightLink;
        public Node* leftLink;
    }
}
