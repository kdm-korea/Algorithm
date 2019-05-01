using System;

namespace Heap_Sort
{
    class MaxinumHeap : IHeap
    {
        public int[] heap = new int[] { };
        private int rData = default, lData = default;
        private int idx = 1;

        public MaxinumHeap(int heap) {
            this.heap[idx] = heap;
            idx++;
        }

        public void Delete(int data) {
            throw new NotImplementedException();
        }

        public void Insert(int data) {
            int tmp = idx;
            heap[idx] = data;
            while (tmp > 0) {
                if(Compare(FindParent(tmp), heap[idx])) {
                    Swap(FindParent(tmp), heap[idx]);
                }
            }
            idx++;
        }

        private int FindParent(int index) {
            return (heap[index] % 2 == 1) ? heap[(index - 1) / 2] : heap[index / 2];
        }

        private bool Compare(int fst, int sec) {
            return (fst > sec) ? true : false;
        }

        private void Swap(int fst, int sec) {
            int tmp = fst;
            fst = sec;
            sec = tmp;
        }

        //private int FindChild(int data) {
        //    try {

        //    }
        //    catch (IndexOutOfRangeException) {

        //        throw;
        //    }
        //}

        private void InintChild() {
            rData = default;
            lData = default;
        }
    }
}
