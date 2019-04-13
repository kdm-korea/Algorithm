using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Node<T>
    {
        private T value;
        private Node<T> rightNode, leftNode;

        public T Value { get => value; set => this.value = value; }

        internal Node<T> RightNode { get => rightNode; set => rightNode = value; }

        internal Node<T> LeftNode { get => leftNode; set => leftNode = value; }
    }
}
