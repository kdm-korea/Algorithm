using System;

namespace Tree
{
    unsafe class Binarytree : ITree<int, Node>
    {
        Node root;

        public Binarytree(int root) {
            this.root = new Node { data = root };
        }

        public bool Delete(int value) {
            throw new NotImplementedException();
        }

        public Node Find(int value) {
            throw new NotImplementedException();
        }
        
        public unsafe bool Insert(int parent, int child, bool direction) {
            Node childNode = new Node { data = child };
            Node* node = &childNode;

            Node parentNode = Find(parent);
            parentNode.leftLink = node;

            if (direction == Direction.LIFT && root.leftLink == null) {
                root.leftLink = node;
                return true;
            }
            else if(direction == Direction.RIGHT && root.rightLink == null){
                root.rightLink = node;
                return true;
            }
            else {
                Console.WriteLine("노드에 데이터가 있습니다.");
                return false;
            }
        }

        void InitalzationNode(Node node) {
            node.data = default;
            node.leftLink = null;
            node.rightLink = null;
        }
    }

    class eaea
    {
        public void example() {

        }
    }
}
