
namespace Tree
{
    class Program
    {
        static ITree<int, Node<int>> binaryTree;
        static TreeUtill<int> utill;
        static Node<int> node;

        static void Main(string[] args) {
            binaryTree = new BinaryTree<int>(1);
            utill = new TreeUtill<int>();

            binaryTree.Insert(binaryTree.Root(), 2, Direct.Left);
            utill.PrtNullRender(binaryTree.Root());

            binaryTree.Insert(binaryTree.Root(), 3, Direct.Right);
            utill.PrtNullRender(binaryTree.Root());

            binaryTree.Insert(binaryTree.Root().Right, 4, Direct.Right);
            utill.PrtNullRender(binaryTree.Root().Right);

            binaryTree.Insert(binaryTree.Root().Right.Right, 5, Direct.Right);
            utill.PrtNullRender(binaryTree.Root().Right.Right);

            node = binaryTree.Retreive(2);
            utill.PrtNullRender(node);


            node = binaryTree.Retreive(3);
            utill.PrtNullRender(node);

            binaryTree.Delete(3);

            node = binaryTree.Retreive(3);
            utill.PrtNullRender(node);
        }
    }
}
