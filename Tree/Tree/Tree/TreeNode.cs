using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree<T>
    {
        private T value;
        private int level;
        private Tree<T> rightNode, leftNode;

        public int Level { get => level; set => level = value; }

        public T Value { get => value; set => this.value = value; }

        internal Tree<T> RightNode { get => rightNode; set => rightNode = value; }

        internal Tree<T> LeftNode { get => leftNode; set => leftNode = value; }
    }

    class TreeNode<T> : ITree<T>
    {
        List<Tree<T>> tree;

        public bool Create(T root) {
            tree = new List<Tree<T>>();
            tree.Add(new Tree<T> { Level = 1, Value = root });
            return true;
        }

        public bool Delete(T value) {
            while (true) {
                //TODO: FinbyChildNode
            }
            throw new NotImplementedException();
        }

        private bool FinbyChildNode(Tree<T> tree) {
            if (tree.RightNode != default || tree.LeftNode != default) {
                return false;
            }
            else {
                return true;
            }
        }

        public bool Find(T value) {
            throw new NotImplementedException();
        }

        public bool Insert(T parent, T child) {
            throw new NotImplementedException();
        }
    }

    class Example
    {
        TreeNode<string> treeNode = new TreeNode<string>("");

        public void Exam() {
            treeNode = new TreeNode<string>("Hi");
        }
    }
}
