using System.Collections.Generic;

namespace Sort
{
    class QuickSort
    {
        public static void ExecuteSort(List<int> array, int start, int end) {
            if (start > end || start < 0 || end < 0) return;

            int index = partition(array, start, end);

            if (index != -1) {
                ExecuteSort(array, start, index - 1);
                ExecuteSort(array, index + 1, end);
            }
        }

        private static int partition(List<int> array, int start, int end) {
            int length = start;
            int pivot = array[end];

            if (start > end) {
                return -1;
            }

            for (int index = start; index < end; index++) {
                if (array[index] < pivot) {
                    swap(array, index, length);
                    length++;
                }
            }
            swap(array, length, end);

            return length;
        }

        private static void swap(List<int> array, int start, int end) {
            int tmp = array[start];
            array[start] = array[end];
            array[end] = tmp;
        }
    }
}
