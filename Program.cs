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


        // find if integer is a prime number or not
        internal static bool FindPrime(int number)
        {
            /* input :- 20 output :- Not Prime
             * input :- 17 output :- Prime
             * 
             * */
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // find second largest integer in an array using only one loop?
        internal static void FindSecondLargeInArray(int[] arr)
        {
            /* input :- 1 2 3 4 5 output :- 4 
            * */

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); ;
        }

    }
}
