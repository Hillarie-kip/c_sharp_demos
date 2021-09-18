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


       // convert a two-dimensional array to a one-dimensional array?
        internal static void MultiToSingle(int[,] array)
        {
            //Convert 2-D array to 1-D array

            /*Input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 4 2 5 3 6 
             * 
             * */

            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }

    }
}
