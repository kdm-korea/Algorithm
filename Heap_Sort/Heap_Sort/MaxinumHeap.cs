using System;
using System.Collections.Generic;

namespace Heap_Sort
{
    class MaxinumHeap : IHeap
    {
        public List<int> heap = new List<int>();

        public void Insert(int value) {
            heap.Add(value);

            int node = heap.Count - 1;
            while (node > 0) {
                int parent = (node - 1) / 2;
                if (heap[parent] < heap[node])
                {
                    Swap(parent, node);
                    node = parent;
                }
                else {
                    break;
                }
            }
        }

        public int Remove() {
            if (heap.Count == 0)
                throw new InvalidOperationException();

            int root = heap[0];

            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int tmp = 0;
            int last = heap.Count - 1;
            while (tmp < last) {
                int child = tmp * 2 + 1;

                if (child < last && heap[child] < heap[child + 1])
                    child = child + 1;

                if (child > last ||heap[tmp] >= heap[child])
                    break;

                Swap(tmp, child);
                tmp = child;
            }

            return root;
        }

        private void Swap(int parent, int Child) {
            int tmp = heap[parent];
            heap[parent] = heap[Child];
            heap[Child] = tmp;
        }
    }
}
