using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm
{
    class Searching
    {
        public void LinearSearch(int[] A, int input)
        {
            bool isFound = true;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == input)
                {
                    Console.WriteLine($"\n\nFound {input}");
                    return;
                }
                else
                {
                    isFound = false;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"\n\nNot found {input}");
            }
        }
    }
}
