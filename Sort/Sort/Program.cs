using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static CompareSortTime com = new CompareSortTime();
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args) {
            //Create 100,000 integer random number
            com.CollectRandomNumber();
        
            // C# library sorting way
            stopwatch.Start();
            com.C_ShapLibrarySort(com.cShap_SortNum);
            stopwatch.Stop();
            Console.WriteLine($"C# library sort timestamp :: {stopwatch.ElapsedMilliseconds.ToString()}ms");

            // Reset stopwatch
            Console.WriteLine();
            stopwatch.Reset();
            Console.WriteLine();

            //Custom quicksorting way
            stopwatch.Start();
            com.Custom_QuickSort(com.quick_SortNum);
            stopwatch.Stop();
            Console.WriteLine($"Custom quicksort timestamp :: {stopwatch.ElapsedMilliseconds.ToString()}ms");
        }




    }
}
