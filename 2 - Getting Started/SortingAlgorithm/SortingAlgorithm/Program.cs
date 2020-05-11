using System;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {5, 2, 4, 6, 1, 3};

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.SortDescending(A);            

            Searching search = new Searching();
            search.LinearSearch(A, 10);
        }
    }
}