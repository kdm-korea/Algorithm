using System;

namespace Tree
{
    class TreeUtill<T>
    {
        public void PrtNullRender(Node<T> node) {
            Console.WriteLine();
            Console.WriteLine("==============================");
            try {
                Console.WriteLine($"node.Data :: {node.Data}");
            }
            catch (NullReferenceException) {
                Console.WriteLine($"node.Data :: null");
            }

            try {
                Console.WriteLine($"node.Right.Data :: {node.Right.Data}");
            }
            catch (NullReferenceException) {
                Console.WriteLine($"node.Right.Data :: null");
            }

            try {
                Console.WriteLine($"node.Left.Data :: {node.Left.Data}");
            }
            catch (NullReferenceException) {
                Console.WriteLine($"node.Left.Data :: null");
            }
            Console.WriteLine("==============================");
        }
    }
}
