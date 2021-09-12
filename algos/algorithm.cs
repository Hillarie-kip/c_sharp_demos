using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_demos.algos
{
    class algorithm
    {
        public static void bubbleSort()
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            int t;
            Console.WriteLine("Original array :");

            foreach (int aa in a)
                // original array
                Console.Write(aa + " ");

            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in a)

                //sorted array
                Console.Write(aa + " ");


        }



        public static void quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = quickSortPartition(arr, left, right);

                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }

        private static int quickSortPartition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }


    }
}
