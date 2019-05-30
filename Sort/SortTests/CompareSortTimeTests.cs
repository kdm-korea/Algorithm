using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass()]
    public class CompareSortTimeTests
    {
        CompareSortTime com = new CompareSortTime();

        [TestMethod()]
        public void CollectRandomNumberTest() {
            Assert.IsTrue(com.CollectRandomNumber());
        }

        [TestMethod()]
        public void C_ShapLibrarySortTest() {
            Assert.IsTrue(com.C_ShapLibrarySort(com.cShap_SortNum));
        }

        [TestMethod()]
        public void Custom_QuickSortTest() {
            Assert.IsTrue(com.Custom_QuickSort(com.quick_SortNum));
        }
    }
}