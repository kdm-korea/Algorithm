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
            maxHeap = new MaxinumHeap(1);

            maxHeap.Insert(10);
            maxHeap.Insert(13);
            maxHeap.Insert(9);
            maxHeap.Insert(6);
            maxHeap.Insert(1);
            maxHeap.Insert(15);

            maxHeap.Delete(10);

            foreach (var i in maxHeap.heap) {
                Console.WriteLine(i);
            }
        }
    }
}
