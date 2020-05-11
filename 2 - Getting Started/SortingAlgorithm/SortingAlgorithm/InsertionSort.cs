using System;

namespace SortingAlgorithm
{
    public class InsertionSort
    {
        public void SortAscending(int[] A)
        {            
            int[] temp = A;

            Notify("Before Ascending", temp);

            for (int i = 1; i < temp.Length; i++)
            {
                int key = temp[i];
                int j = i - 1;

                while (j >= 0 && temp[j] > key)
                {
                    temp[j + 1] = temp[j];
                    j = j - 1;
                }

                temp[j + 1] = key;
            }
            
            Notify("After Ascending", temp);
        }

        public void SortDescending(int[] A)
        {
            int[] temp = A;

            Notify("Before Descending", temp);

            for (int i = 1; i < temp.Length; i++)
            {
                int key = temp[i];
                int j = i - 1;

                while (j >= 0 && temp[j] < key)
                {
                    temp[j + 1] = temp[j];
                    j = j - 1;
                }

                temp[j + 1] = key;
            }

            Notify("After Descending", temp);
        }

        public void Notify(string notif, int[] A)
        {
            Console.WriteLine($"\n{notif} INSERTION-SORT()");
            foreach (var value in A)
            {
                Console.Write($"{value} ");   
            }
        }
    }
}