using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class BinaryTree<T> : ITree<T, Node<T>>
    {
        List<Node<T>> tree;

        public BinaryTree(T root) {
            tree.Add(new Node<T> { Value = root });
        }

        public bool Delete(T value) {
            while (true) {
                //TODO: FinbyChildNode
            }
            throw new NotImplementedException();
        }

        private bool FinbyChildNode(Node<T> tree) {
            if (tree.RightNode != default || tree.LeftNode != default) {
                return false;
            }
            else {
                return true;
            }
        }

        public Node<T> Find(T value) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// direction [0 = Right, 1 = Left]
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Insert(T parent, T child, bool direction) {
            throw new NotImplementedException();
        }
    }
}
