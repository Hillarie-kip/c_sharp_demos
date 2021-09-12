using c_sharp_demos.algos;
using System;

namespace c_sharp_demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverseWord("Hello World!");

            //algorithm.bubbleSort();




            //QUICKSORT
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            algorithm.quickSort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();




        }
    
    
    





        static void reverseWord(string str)
        {
            char[] array = str.ToCharArray();

            Console.WriteLine(array);
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                array[i] = str[j];
                array[j] = str[i];

            }
            string reversed = new string(array);
            Console.WriteLine(reversed);

        }
    }
}
