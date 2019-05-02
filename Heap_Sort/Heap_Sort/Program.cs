using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static MaxinumHeap maxHeap;

        static void Main(string[] args) {
            maxHeap = new MaxinumHeap();

            maxHeap.Insert(10);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Insert(13);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Insert(9);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Insert(6);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Insert(1);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Insert(15);
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            maxHeap.Remove();
            foreach (var i in maxHeap.heap) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
