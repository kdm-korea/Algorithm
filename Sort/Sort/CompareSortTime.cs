using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public class CompareSortTime
    {
        public List<int> quick_SortNum = new List<int>();
        public List<int> cShap_SortNum = new List<int>();

        public bool CollectRandomNumber() {
            RandomNumber randomNumber = new RandomNumber();

            quick_SortNum = randomNumber.Create_RandomNumber(); // Create Random Integer Number 1 ~ 100,000
            quick_SortNum = cShap_SortNum.ToList();             // Deep copy
            return true;
        }

        public bool C_ShapLibrarySort(List<int> num) {
            try {
                num.Sort();
                return true;
            }
            catch (System.Exception) {
                return false;
            }
        }

        public bool Custom_QuickSort(List<int> num) {
            return true;
        }

    }
}
