using System;

namespace Tree
{
    class BinaryTree<T> : ITree<T, Node<T>>
    {
        private Node<T> root;
        private Node<T> resultNode = default(Node<T>);

        public BinaryTree(T root) {
            this.root = new Node<T> { Data = root };
        }

        public bool Delete(T data) {
            try {
                DeleteRecurrent(Retreive(data));
            }
            catch (Exception) {
                return false;
            }
            return true;
        }

        private void DeleteRecurrent(Node<T> node) {
            if (node != default(Node<T>)) {
                Initialization(node);
                DeleteRecurrent(node.Left);
                DeleteRecurrent(node.Right);

                if (node.Left != default(Node<T>) && node.Right != default(Node<T>)) {
                    return;
                }
            }
        }

        public Node<T> Retreive(T data) {
            PreOrderRecurrent(root, data);
            if (data.Equals(resultNode.Data)) {
                return resultNode;
            }
            return default(Node<T>);
        }

        public bool Insert(Node<T> node, T data, Direct direct) {
            if (direct.Equals(Direct.Left)) {
                node.Left = new Node<T> { Data = data, };
                return true;
            }
            else if (direct.Equals(Direct.Right)) {
                node.Right = new Node<T> { Data = data };
                return true;
            }
            return false;
        }

        public Node<T> Root() => this.root;

        private void Initialization(Node<T> node) {
            node.Data = default(T);
            node.Left = default(Node<T>);
            node.Right = default(Node<T>);
        }

        private void PreOrderRecurrent(Node<T> node, T data) {
            if (node != default(Node<T>)) {
                PreOrderRecurrent(node.Left, data);
                PreOrderRecurrent(node.Right, data);

                if (node.Data.Equals(data)) {
                    resultNode = node;
                }
            }
        }
    }
}
