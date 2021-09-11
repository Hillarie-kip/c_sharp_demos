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
    }
}
