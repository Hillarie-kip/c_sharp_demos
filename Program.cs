using System;

namespace c_sharp_demos
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseWord("Hello World!");
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
