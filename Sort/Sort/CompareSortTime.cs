using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public class CompareSortTime
    {
        public List<int> quick_SortNum = new List<int>();
        public List<int> cShap_SortNum = new List<int>();
        RandomNumber randomNumber = new RandomNumber();

        public bool CollectRandomNumber() {
            quick_SortNum = randomNumber.Create_RandomNumber(); // Create Random Integer Number 1 ~ 100,000
            cShap_SortNum = quick_SortNum.ToList();             // Deep copy
            return true;
        }

        public bool C_ShapLibrarySort(List<int> num) {
            num.Sort();
            return true;
        }

        public bool Custom_QuickSort(List<int> num) {
            QuickSort.ExecuteSort(quick_SortNum, 0, quick_SortNum.Count - 1);
            return true;
        }

    }
}
